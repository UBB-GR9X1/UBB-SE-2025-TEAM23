# Stock System (Page) - Iosua

 The system should provide users with information regarding a specified stock: 
- Guests and Registered Users should be provided with:
  - The ability to go back to the previous page:
    - This will be achieved through a button with the text "Back", which if clicked redirects the viewer back to the previous page (the system saves a history of the previous pages).
  - The symbol of the stock. A label.
  - The name of the stock. A label.
  - A button containing the username of the author of the stock, which if clicked redirects the viewer to the profile page of the author user.
  - The stock price history up to 30 values (including the current price) in the form of a graph.
    - If the stock does not have a history of prices, only the current price, the graph should be empty.
  - The current price of the stock, followed by the text " Gems". A label.
  - If the stock has a history of at least one value, display the change in the value of the stock (in percentage, whole numbers) [(current stock / last history stock value) * 100]. A label.
- Registered Users should additionally be provided with:
  - A button:
    - If the user does not have the stock saved as a favorite:
      - Displaying an image of an empty star with a yellow outline.
      - when the button is clicked, save the stock as a favorite for the user and update the button.
    - If the user does have the stock saved as a favorite:
      - Displaying an image of a filled star colored yellow.
      - when the button is clicked, save the stock as not a favorite for the user and update the button.
  - A button displaying an image of a bell, which if clicked redirects the viewer to the alarm manager page for this stock.
  - The number of gems the user has. A label.
  - A number input to select the amount of stocks to buy or sell. The default value is 0.
  - A button displaying the text "Buy!", which if clicked, validates if the user has the necessary Gems to buy (n * current stock price), where n is the value entered in the input above, should be equal or lower than user gems.
    - If requirements are met, the system will subtract the discussed amount (n * current stock price) from the user's gems and add to their current stocks the stock bought by the amount selected. The system should add the current stock price to the stock price history and generate a new current stock price by the following formula Maximum between (current stock price - random number between 0 and 20) and 50. After the price has been changed, run the alerts system bounds check for this stock. The system will save a new transaction in the transacrion history composed of stock symbol, stock name, transaction type BUY, n, current stock price, n * current stock price, the date at which the transaction was executed, user.
    - Otherwise, display a popup warning with the text "Invalid number input selected".
  - A button displaying the text "Sell!", which if clicked, validates if the user has the necessary Stocks of this type (count of user stocks of this type > n).
    - If requirements are met, the system will subtract the discussed amount and type (n * current stock price) from the user's stocks and add to the user's gems (n * current stock price). The system should add the current stock price to the stock price history and generate a new current stock price by the following formula Maximum between (current stock price + random number between 0 and 20) and 50. After the price has been changed, run the alerts system bounds check for this stock. The system will save a new transaction in the transacrion history composed of stock symbol, stock name, transaction type SELL, n, current stock price, n * current stock price, the date at which the transaction was executed, user.
    - Otherwise, display a popup warning with the text "Invalid number input selected".
