# Create Stock - Ionut

This page should allow users/moderator to define and create a new stock entry, including specifying its details such as name, category, price, and initial quantity. The UI should be user-friendly and responsive, following the application’s theme. The data should be validated before submission and stored in the database through a database wrapper.
Ensure that guest users cannot create a new stock entry. If a guest user accesses the Stock Creation page, display a message informing them that stock creation is restricted to registered users. The UI should prevent any form submissions from guests and hide or disable input fields accordingly
Stock Creation Form:
- Input fields for: 
  - Stock Name (max 20 characters)
  - Logo Upload (max 2MB, image file=
  - Category (Dropdown or Text Input)
  - Initial Quantity (float, between 1 - 1,000,000)
  - Price per Unit (float, between 1 - 100)
  - Description (Optional, max 200 characters)
- Submit & Reset Buttons
- Real-time Validation (e.g., prevent negative quantities, missing fields)
- Success/Error Notifications after form submission
