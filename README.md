# Lab4

1. Go to -> tools -> NuGet -> Console and run `Install-Package log4net`. 
(This command install the log4net package that we will use latter in this exercise)
2. Create a new branch `git checkout -b login`
3. Write a C# method that takes as a user input userid and password (type string). After 3 wrong attempts, user will be rejected.
4. Don't forget to add and commit after each step.
5. Merge back the branch to the master
6. Delete the login branch (See presntaion form the previous lab).
7. Create a new branch `git branch log-login`
8. On the master add a message for failed and successful logins.
9. Additionally, add a `Hashtable` that will store a hard coded usernames and passwords.
10. Change your function that login validation will use the created `Hashtable`.
11. Move to branch log-login `git checkout log-login`
12. Add logging for each successful and failed attempts logging the username and number of attempt.
13. Give different levels of  log message to different log messages.
14. Merge back to the master
15. Resolve all the conflicts
