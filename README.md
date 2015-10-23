#ApacheHelper
A user friendly tool to assist in configuring the apache enviorment. Currently geared toward XAMPP stacks
In a nutshell...a simple tool for a simple job. Saves me a ton of time in the process of configuring virtual host and adding to the hosts file
## Features:
 - Simple document root moving 
 - Simplifies VHOST and HOST adding
 
##Required:
 - XAMPP : https://www.apachefriends.org/index.html
 - .Net framework 4.5 : http://www.microsoft.com/en-us/download/details.aspx?id=30653
    - On most Windows 8/8.1/10 Installs this should be there by default
    - If you want it for any other version of .Net just download the source and change the application framework to whatever you want.
 - Administrator Priveleges
 - Probably should backup your conf files. Specifically httpd.conf and httpd-vhost.conf
 
##Instructions:

###Moving your document root:

    Moving your document root allows you to server your files from outside htdocs. 
    You can move your document root into any folder you want.
    
    Step 1. Click Document Root button
    Step 2. Browse to whichever folder you would like to be your document root
    Step 3. Hit Ok. You will notice the text next to the document root will reflect your changes
    Step 4. Restart Apache
    Step 5. DONE!
###Creating a new VHOST and HOST entry
  
   The following procedure will create a whole new entyr in your httpd-vhost.conf file as well as your window HOSTS file
   
    Step 1. Click New VHOST button
    Step 2. Browse to where you want your public root to be ( where html/css/js is served ). 
            This is commonly known as the public_html folder or public folder 
    Step 3. Hit Ok. You will notice one new entry in your VHOST view and another in your HOST view
    Step 4. Restart Apache
    Step 5. Done
