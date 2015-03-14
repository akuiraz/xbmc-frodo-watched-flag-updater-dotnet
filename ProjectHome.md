# XBMC Watched Flag Helper 2.9 #

For those Windows users like me who prematurely upgraded to Frodo before checking if they could carry on using the xbmc-watched-data add-on, this .net app can set the watched flag for XBMC videos in either a shared MySQL library or the normal local SQLite .db file.

You can use this app with Frodo to import the watched.xml file created by the old add-on, and also export back out a similar xml file.  You don't need to install anything else as I've included all the necessary dlls.

## FAQ ##

**What is the username and password for the databases?**

The local .db file doesn't need a password, but the username and password for the shared library is normally ‘xbmc’.


**What is the database name?**

The remote database name for XBMC is currently myvideos75.  However, this does change when different versions of XBMC are released.  Those not using a Windows server may need to capitalise the database name, e.g. MyVideos75.


**Is this app compatible with XBMC 13.0 Gotham?**

Yes - just change the database name to MyVideos78.


## Changelog ##
2.9 - Results of an import/export are no longer displayed in a message box, instead they are in the status strip

2.7 - Enhanced error handling and minor bug fixes

2.2 - Minor bug fixes & textbox added to allow users to specify the remote database name.  This will help future-proof the app against upgrades to XBMC, and should make the app work with Eden

2.1 - Source code removed from zip file

2.1 - Remote MySQL database DLLs included in project - no need to install separate adapter

2.0 - Local SQLite database support added

1.0 - Remote MySQL database support added