# Gem store - Ana 
- This requirement interacts with TEAM 7UP to retrieve the account list and request subtraction or addition of funds to an account.

-	The Gem Store shall allow registered users to purchase and sell in-app currency (Gems) for real money. These Gems can be used later to acquire stocks.
-	Guest users shall only be allowed to view Gem Deals without the ability to buy or sell Gems.

**Buying gems:**
- Users shall scroll through a list of Gem Deals, which can be permanent or special (available for a limited time).
- Each Gem Deal shall display:
  - A title.
  - The number of Gems included.
  - The price in real money.
- After selecting a deal, the user shall be prompted to choose a bank account from which the money will be deducted.
- A "BUY" button shall finalize the transaction once a bank account is selected, the user’s account being updated with the purchased Gems.

**Selling gems:**
- The system shall display the exchange rate: 100 Gems = 1 Euro.
- Users shall input the number of Gems they wish to sell.
- The system shall validate that:
  - The input is greater than 0.
  - The user has sufficient Gems to sell.
- If the input is invalid, the system shall display a specific error message.
- If the input is valid, the user shall be prompted to choose a bank account where the real money will be deposited.
- A "SELL" button shall finalize the transaction once a bank account is selected.

**Gem Deals:**
- The system shall display a list of Gem Deals in a scrollable container.
- Special Gem Deals shall be highlighted with a label "Special offer!" and shall expire after a set period.
- Expired special deals shall be replaced with new ones after a cooldown period.

**Bank Account Selection:**
- When buying or selling Gems, the user shall be prompted to select a bank account from a modal window.
- The modal shall list the user’s bank accounts and require a selection to proceed.

**Back Button:**
- A back button shall be shown in the top-left corner of the Gem Store page.
- The button shall be an arrow pointing to the left.
- Pressing the button shall navigate the user back to the home page.
