This is a remote utility for managing windows services and software.

The program is written in C# using .NET Framework 4.5. The program is used to remotely assist computer support. Services can be started and stopped. Software can be uninstalled. Lots of system info is listed.

This app uses DOMAIN security! You MUST have a domain account with permission to the remote machine. Loopback interface is also supported (127.0.0.1).  

Workgroup environments now work with the addition of the username/password fields. 

NOTE: leaving User Name and Password fields blank or not checking the "Requires Credentials" checkbox will use current user credentials from the machine where the app is running from. 

Note on Exporting: The application will currently only export a single system (the info from the main window will be used for exporting). It will create separate worksheets (Excel tabs) for each checkbox ticked.

Multiple systems is still in development.  Multiple system export development has been halted for now.  This may come later in the future, but for now the feature is low-priority and mostly out of scope of the application's purpose.  
