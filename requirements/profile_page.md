# Profile - Bianca
- This application relies on a function of the TEAM 7UP to provide the account-related user data, mainly the CNP.

guest = unregistered user

When creating an account, it should be creating using the CNP(it is taken from the user's banking account and it is unique for each user), the user shall be provided by the system with a username which is initially a predefined name (random name from a list - the username is not necessarily unique for each user).
---- For every NEW user the profile image will be empty, the description box will be empty and their list of stocks will be empty.

The user's profile:
The system shall allow the user to update their profile information as follows:
- the username - it has to be between 8-24 characters long and it has to contain only letters and numbers
- the profile picture - it has to be a PNG file
- the description - a block of text that can have between 0 and 100 characters
- the option to have a hidden profile - if this option is enabled the profile page (profile picture, description and the user's stocks) will be hidden from other users. Only the username will be accessible and visible
- the option to become "admin" - once a user becomes admin he cannot undo it - In order to become admin the system will ask for a password (password: BombardinoCrocodilo). The system will compare the hash of this password with a saved hash and if they match the user should be promoted to an "admin".

Admin:
The admin will have the ability to remove articles from the News Page.

The system will give the users the ability to see other users' profile (image, username, description and stocks). They can modify their account but not others'. They can only view other users' accounts without any modification - only if their profile is not set to "hidden".

Stocks:
Besides the other information about the user (username, image and description), the system will give the user the ability to see his stocks as a list (in no specific order). Each element (stock) will have the following information:
- the symbol of the stock. label 
- the name of the stock. label.
- the quantity the user bought. label.
- the current value of the stock. label.
- a button with the text Enter" which if it is clicked, the system will let the user view the stock page for that specific stock

There will also be a button with the text "Back" that if it is clicked, the system will let the user go back to the previous page.
