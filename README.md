Outline of Car Garage System

The system is made up of a local database and several windows forms. The local database records all customers, cars, jobs, job cards and current staff. I have entered all twenty-five current staff of AutoJalopy Motors into the database with a unique user ID and the password.

Some useful user IDs and Passwords are as follows:

Name	- Role -	User ID -	Password


Mr Arthur Daley -	Managing Director	-  25 - 	ireland
Mr Jose Mourinho -	Head Mechanic -	22 - 	SpecialOne
Mr Jack Admin -	Administration -	10000	- admin
Mr Aaron Ramsey -	Mechanic -	1 - 	arsenal

When a user successfully logs into the system, they are presented with a main menu which has four options as follows:
1.	View Reports: In view reports one will find the three reports.

2.	View Bookings: This is the main administration part of the system. 
On this form, admin users can add new customers, cars and jobs cards. 
They can also search and edit existing customers, their cars and associated job cards. 
If an admin user searches for a customer and then selects that customer from the datagrid, that customer’s cars will automatically appear in the second datagrid. 
The admin user can then select the car they wish and any job cards associated with that car will appear in the third datagrid. 

3.	View Your Workload: This form is aimed at the mechanics. 
This form loads all of the logged in mechanic’s current jobs. 
When they have completed a job they have the option to delete it from the datagrid.

4.	Logout: This logs out the current user and returns the application to the log in form. 
I have built the system to deny access to certain forms based on the current logged in user’s credentials. 
For example, only admin users can access all customer details and all jobs. For this reason, I have made the main administration form accessible only to staff who are registered as admin in the database.
I have also restricted access to report number one which lists each mechanic’s workload for the next two weeks to just the MD and the head mechanic.
Please use the appropriate user ID’s and passwords listed above to test this. 

The database has been pre-populated with some sample data for testing purposes. 





