# Alert Management System - Rafa
All the following are only applicable to registered users.
The system should allow users to set alerts on stock prices and notify users when a stock's price has gone outside a bound interval.
- On startup, the system should provide the user with a list of triggered alerts. An alert is triggered when the price of the stock on which the alert is set goes outside a bound interval set by the user.
- The system will display:
  - A list of all triggered alerts, containing the following:
    - The alert label.
    - The stock name on which the alert is ser.
    - The current price of the stock.
    - A button with the text "Enter" that redirects to the stock page for the respective stock.
  - A button displaying the text "Close" that redirects to the Main Page.

The user can access the alert management system via the stock page system.
The system should provide a user with the following for a specific stock:
  - A list of all saved alerts composed of the following:
    - The alert label.
    - The stock name on which the alert is set.
    - The lower bound limit on the price of the stock.
    - The upper bound limit on the price of the stock.
  - The system should allow users to remove alerts via a button next to each alert with the text "Remove".
  - The system should allow users to create alerts in the following manner:
    - The system should display the following for alert creation:
      - The alert label. A text input is limited to 32 characters. 
      - The lower bound limit on the price of the stock. A number input with default value 0.
      - The upper bound limit on the price of the stock. A number input with default value 0.
      - A button displaying the text "Create", which if clicked validates the input of both text inputs to be above 0, otherwise displays a popup alert with the text "Number input value must be above 0", and validates if the lower bound input value is lower than the upper bound input value otherwise displays a popup alert with the text "The lower bound value must be lower than the upper bound value". The stock is automatically assigned with the stock of the stock page that initialized the alert page. The system should save the new alert with the data above and update the alert list.
