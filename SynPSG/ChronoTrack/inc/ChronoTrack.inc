;;**********************************************************************
;;
;; Title:       ChronoTrack.inc
;;
;; Type:        include file
;;
;; Description: Include file containing standard definitions
;;
;; Author:      Richard C. Morris, Synergex Professional Services Group
;;
;; Copyright:   ©Synergex International Inc.  All rights reserved.
;;
;; WARNING:     If you were given this code by a Synergex employee then
;;              you may use and modify it freely for use within your
;;              applications.
;;
;;              However, you may not under any circumstances distribute
;;              this code, or any modified version of this code, to any
;;              third party without first obtaining written permission to
;;              do so from Synergex.  In using this code you accept that it
;;              is provided as is, and without support or warranty.
;;
;;              Neither Synergex or the author accept any responsibility
;;              for any losses or damages of any nature which may arise
;;              from the use of this code.  This header information must
;;              remain unaltered in the code at all times.  Possession of
;;              this code, or any modified version of this code, indicates
;;              your acceptance of these terms.
;;
;; $Revision: 2 $
;;
;; $Date: 2008-11-07 21:00:53+00:00 $
;;***********************************************************************************
;;
;;ChronoTrack is an open ware application written by and managed by the
;;Synergex Professional Services Group.
;;
;;The code contained within this file should not be modified.  All modifications
;;should be submitted to Synergex for review and inclusion in a future release
;;
;;***********************************************************************************

;;; <summary>define macros to allow easy access to the debugger window </summary>
.define debugInfo(msg) Debugger.InfoMessage(msg)
.define debugError(msg) Debugger.ErrorMessage(msg)

