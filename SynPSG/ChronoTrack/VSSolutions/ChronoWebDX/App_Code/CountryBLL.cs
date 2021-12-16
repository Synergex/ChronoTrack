/******************************************************************************
 *
 * Author:      Steve Ives
 *
 * Company:     Synergex Professional Services Group
 *
 * Created:     01/23/2009 at 15:36
 *
 ******************************************************************************
 *
 * This class is the business object for the CountryDT class. It is used
 * by the ObjectDataSource controls on forms.
 * 
 * This code is supplied as seen and without warranty or support, and is used
 * at your own risk. Neither the author or Synergex accept any responsability
 * for any loss or damage which may result from the use of this code. This text
 * must remain unaltered in this file at all times. Possession or use of this
 * code, or any modified version of this code, indicates your acceptance of
 * these conditions.
 *
 ******************************************************************************
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.SessionState;
using ChronoTrack;

[DataObject]
public class CountryBLL
{
    private HttpSessionState Session;

    //Constructor
    public CountryBLL()
    {
        Session = HttpContext.Current.Session;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public CountryDT GetAllCountrys()
    {
        //Create a data table to return
        CountryDT countryDT = new CountryDT();

        //Do we have an existing cache?
        if (Session["CACHE_COUNTRY"] != null)
        {
            //Yes, return the cached table
            countryDT = (CountryDT)Session["CACHE_COUNTRY"];
        }
        else
        {
            //No, get the table from the server
            bool methodOK = false;
            try
            {
                methodOK = SynUtils.Server.GetCountryTable(SynUtils.UserToken, ref countryDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CountryBLL", "GetCountryTable");
            }

			//If we got data back then cache it for next time
            if (methodOK && (countryDT.Rows.Count > 0))
                Session.Add("CACHE_COUNTRY",countryDT);
        }

        return countryDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public Country GetCountry(string CountryId)
    {
        Country country = new Country();

        //Make sure we have any required parameters
        if (CountryId != null)
        {
            try
            {
                SynUtils.Server.GetCountry(SynUtils.UserToken, CountryId, ref country);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CountryBLL", "GetCountry");
            }
        }

        return country;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public bool AddCountry(Country country)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (country != null)
        {
            //Create the record on the server
            try
            {
                recordCreated = SynUtils.Server.CreateCountry(SynUtils.UserToken, ref country);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CountryBLL", "CreateCountry");
            }

            //If the server create was successful then add the item to any cache
            if (recordCreated && (Session["CACHE_COUNTRY"] != null))
            {
                CountryDT countryDT = (CountryDT)Session["CACHE_COUNTRY"];
                countryDT.AddRow(country);
                countryDT.AcceptChanges();
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public bool UpdateCountry(Country country)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (country != null)
        {
            //Save the original GRFA so we can locate the updated record in cache if necessary
            string originalGrfa = country.Synergygrfa;
			string newGrfa = "";
		
           //Update the record on the server
            try
            {
                recordUpdated = SynUtils.Server.UpdateCountry(SynUtils.UserToken, country, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CountryBLL", "UpdateCountry");
            }

            //If the server update was successful then update the item in any cache
            if (recordUpdated && (Session["CACHE_COUNTRY"] != null))
            {
                //Find the existing row to be updated in cache
                CountryDT countryDT = (CountryDT)Session["CACHE_COUNTRY"];
                string selectStatement = string.Concat("Synergygrfa='",originalGrfa,"'");
                DataRow[] affectedRows = countryDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0]["Synergygrfa"] = country.Synergygrfa;
                    affectedRows[0]["Country_id"] = country.Country_id;
                    affectedRows[0]["Country_name"] = country.Country_name;
                    affectedRows[0]["Dialing_code"] = country.Dialing_code;
                    affectedRows[0]["Currency_code"] = country.Currency_code;

                    //Store the new GRFA that came back from the update method
                    affectedRows[0]["Synergygrfa"] = newGrfa;

                    //Commit the changes to the table
                    countryDT.AcceptChanges();
                }
                else
                {
                    //No, something got out of step!
                    invalidateCache();
                }
            }
        }

        return recordUpdated;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public bool DeleteCountry(Country country)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (country != null)
        {
            //Delete the record on the server
            try
            {
                recordDeleted = SynUtils.Server.DeleteCountry(SynUtils.UserToken, country);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CountryBLL", "DeleteCountry");
            }

            //If the server delete was successful then delete the item from any cache
            if (recordDeleted && (Session["CACHE_COUNTRY"]!=null))
            {
                //Find the row to be deleted
                CountryDT countryDT = (CountryDT)Session["CACHE_COUNTRY"];
                string selectStatement = string.Concat("Synergygrfa='",country.Synergygrfa,"'");
                DataRow[] affectedRows = countryDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0].Delete();
                    countryDT.AcceptChanges();

                    //If the table is now empty then remove the cache
                    if (countryDT.Rows.Count == 0)
                        invalidateCache();
                }
                else
                {
                    //No, something got out of step
                    invalidateCache();
                }
            }
        }

        return recordDeleted;
    }

    private void invalidateCache()
    {
        HttpSessionState Session = HttpContext.Current.Session;
        Session.Remove("CACHE_COUNTRY");
    }
}
