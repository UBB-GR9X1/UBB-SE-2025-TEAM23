# Home Page - Riky
- The homepage should also enable users to navigate to the Profile, Store, History, Create Stock, News.
- The homepage shall display the following:
  - A button displaying the text "Profile", which if clicked redirects to the profile page.
  - A button displaying the text "Store", which if clicked redirects to the gem store page. 
  - A button displaying the text "History", which if clicked redirects to the transaction log page.
  - A button displaying the text "Create Stock", which if clicked redirects to the create stock page. This button is only displayed for registered users.
  - A button displaying the text "News", which if clicked redirects to the news page.
  - If the user is a Guest: A button displaying the text "Create Profile", which if clicked, the user's cnp will be added into the database, becoming a User.
  - The button described above will be shown ONLY if the user using the app is a Guest.
- The homepage of the Stocks App should allow all users to view stock details, by displaying a comprehensive list of all available stocks, each showing:
  - a stock symbol (a maximum of four uppercase letters), 
  - the full stock name, 
  - the latest available price, 
  - and the percentage change relative to the last recorded value in the history if the history contains at least one recorded value. 
  - All users should be able to search for stocks by: 
    - symbol, a text input, containing alphabetical characters (A-Z), with a maximum of 4 characters.
    - name, a text input, containing alphabetical characters (A-Z), with a maximum of 50 characters.
  - Allow all users to have filtered stocks, and sort them by: (a drop-down menu containing label texts)
    - "Name" (A-Z or Z-A), 
    - "Price" (ascending or descending),
    - "Percentage Changed" (ascending or descending) 
  - A separate section of the page should display the registered user's favorite stocks, allowing them to mark or unmark stocks as favorites.
    - The registered users will be able to mark / unmark stocks as "Favorite"
    - The Guests will not be able to mark / unmark stocks as "Favorite"
