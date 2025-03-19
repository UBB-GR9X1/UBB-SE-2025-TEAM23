# Create Stock - Ionut

This page allows registered users and moderators to define and create a new stock entry by specifying details such as name, category, price, and initial quantity.
 
 ## Requirements:
 User Access Control:
 
   - Guest users cannot create stock entries.
   - If a guest accesses this page, display a message restricting stock creation to registered users.
   - Hide or disable form inputs for guests to prevent submissions.
 ## Stock Creation Form:
 
 ### Fields:
  - Stock Name (Max 20 characters, only letters & spaces)
  - Category (Dropdown or text input)
  - Initial Quantity (Float, 1 - 1,000,000)
  - Price per Unit (Float, 1 - 100)
  - Description (Optional, Max 200 characters)
 ### Buttons:
   - Submit: Validates and stores data in the database via a wrapper.
   - Reset: Clears all input fields.
 ### Validations:
   - Prevent invalid input (negative values, missing fields, or exceeding limits).
   - Real-time validation with error messages.
 ### Feedback:
   - Display success/error notifications upon submission.
 ### UI Considerations:
   - Ensure a user-friendly and responsive design following the application’s theme.
