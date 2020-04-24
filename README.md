# COVID19-hackthon-project

# Overview of the Project
This project gathers relevent scientific data from the Global Health Organization into a web app and database. The application allows the user to search upon 'Article Title', 'Author', 'Publishing Journal', and any keywords found in the abstract. The data is dynamically loaded to the web page into a readable manner. Each result also contains a DOI link, which allows the user to reference the full scientfic article. The database currently has over 2000 articles and it will grow as more data gets released by the Global Health Organization

# Tools used
I used the .NET CORE MVC Framework for my backend weblogic. This is connected to a localized SQLite database to transact the article information and to allow for further maintinece in the future. I used a combonation of JS, CSS, CSHTML, and the Bootstrap framework to build out the frontend of the website.

# How to run
In order to run the Web application, you will need to clone the repository to your local machine. Change directories into the repo and then run 'dotnet run'. (You will need to preinstall the dotnet framework before you can run this command) This will launch the webserver on '127.0.0.1:5001' and you can then use that local ip address to view it in any browser. 
