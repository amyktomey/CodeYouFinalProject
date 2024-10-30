# CodeYouFinalProject

Automate 7 test cases

Must have proper POM design pattern (each page of website must have corresponding page of locators and relevant helper methods)
(Documentation with examples for POM design pattern https://toolsqa.com/selenium-webdriver/page-object-model/)

		At least one [TestMethod] should use the DataRow attribute
		At least one example of IJavaScriptExecutor
		At least one example of SelectElement
		At least one example of Actions class
		At least one use of extension method
		At least one use of WebDriverWait (no hard coded implicit waits)
		Multiple assertions per test
		Make sure the tests are intelligently named

Selenium helper methods should be in their own class

You are the designated automation engineer at a Human Resources Management software company. The below manual test suite has been assigned to you this sprint. It is your job to automate the below test cases. 

Admin Page - Search and Edit User

Prerequisites 
Navigate to https://opensource-demo.orangehrmlive.com/web/index.php/auth/login and login with valid credentials

1) Click on the Admin tab
2) Search for user via the Username
3) Click on Edit Button
4) Edit all fields available and save
5) Search for same user using one of the new field values you provided
6) Make sure all fields are the new ones you edited 
6) Delete the user
7) Make sure the user no longer exists

Admin Page - Add new user and make sure user can login

Prerequisites 
Navigate to https://opensource-demo.orangehrmlive.com/web/index.php/auth/login and login with valid credentials

1) Navigate to Admin page
2) Create a new user with Admin role
3) Make sure User is enabled
4) Employee name has to be one that is already in the system
5) Give User a username and password
6) Save User
7) Logout and then log back in using the credentials you just created
8) Make sure you are actually logged in as that user that you just created

My Info Page - Change User Name

Prerequisites 
Navigate to https://opensource-demo.orangehrmlive.com/web/index.php/auth/login
 and login with valid credentials

1) Navigate to My Info page
2) In Personal Details, change the Employee Full Name
3) Save your changes
4) Validate that the user name has changed in the top right corner (logged in user should now be the name you changed)

Leave Page - Apply for leave

Prerequisites 
Navigate to https://opensource-demo.orangehrmlive.com/web/index.php/auth/login and login with valid credentials

1) Navigate to the Leave page
2) Click Apply
3) Select leave type 
4) Use date picker to select a date range in the future (make sure you pay attention to how much time you have available)
5) Fill out comment section
6) Apply
7) Navigate to main leave page and make sure the leave you requested is showing in the results view
8) Navigate to 'My Leave' tab and make sure the leave is there and pending approval
9) Cancel the leave you just requested
10) Make sure the leave is now marked as canceled on the 'My Leave' page
11) Navigate back to main leave page and make sure that leave is no longer in the results view

Help Page - Open new tab

Prerequisites 
Navigate to https://opensource-demo.orangehrmlive.com/web/index.php/auth/login and login with valid credentials

1) Click on help button '?' in top right corner
2) Make sure that a new tab opens 
3) Make sure the following links are present/enabled (Admin User Guide, Employee User Guide, Mobile App, AWS Guide, FAQs)
3) Make sure the Search Bar is present
4) Make sure the Sign in button is displayed

 My Info Page - Upload a file

Prerequisites 
Navigate to https://opensource-demo.orangehrmlive.com/web/index.php/auth/login and login with valid credentials

1) Navigate to My Info Page
2) On one of the tabs in Personal Details, upload a file
3) Save the changes
4) Make sure the file shows up in the grid below
5) Make sure the date matches the day it was uploaded
6) Validate the Type and Added By fields as well

*Tip for testing - make sure the .txt file that you upload is in your project folder and uploaded to git



Wildcard Test Case

This test case is one of your choosing. However, this must be a negative test. The test should be testing something that is expected to fail. However, the test must pass. 
