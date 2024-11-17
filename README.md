# Book Shop Billing System

This is a simple **Book Shop Billing System** built using **C#** and **Windows Forms**. The program allows users to manage a book shop's inventory, perform billing operations, and generate invoices. It interacts with a **SQL Server** database to retrieve book details and update stock levels.

## Screenshots

![image](https://github.com/user-attachments/assets/d7075fdf-a7ba-4e13-95cc-711750d668b6)

![image](https://github.com/user-attachments/assets/aa3a35b9-8620-45b4-968f-88fcee0ef92a)

![image](https://github.com/user-attachments/assets/b1cfa4d7-7cde-4040-9b5e-d28fcac4a650)

![image](https://github.com/user-attachments/assets/f30422be-88ec-4a97-a516-92399d0ebdf9)


## Features

- Display books in the shop using a **DataGridView**.
- Add books to the billing system with quantity and price.
- Update stock quantity after each sale.
- Generate and print invoices with a detailed list of items purchased.
- Basic input validation for fields like price and quantity.
  
## Prerequisites

To run this project, you'll need the following:

- **Microsoft Visual Studio** (or any C# IDE that supports Windows Forms).
- **SQL Server** (or a local database configured for the project).
- Connection to a SQL Server database with a table named `bookTbl` that includes columns for book details like ID, Name, Price, Quantity, etc.

## Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/your-username/book-shop-billing-system.git
   ```

2. Open the project in **Microsoft Visual Studio** or your preferred IDE.

3. Ensure that your **SQL Server** is running and configured properly. Update the connection string in the `Billing.cs` file to match your database setup.

   ```csharp
   SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER_NAME;Initial Catalog=bookShopDb;Integrated Security=True;");
   ```

4. Build and run the project.

## Usage

1. Upon running the program, you will see the book inventory listed.
2. Select a book to add it to the bill by entering the quantity and price.
3. Click **Add to Bill** to add the item to the billing list.
4. Once you've added all items, click **Print** to generate and print the invoice.
5. You can **Reset** the fields or **Refresh** the book list as needed.


## Contributing

Feel free to fork this repository, submit issues, and create pull requests if you want to contribute to this project!

## Acknowledgements

- **C#** and **Windows Forms** for the UI development.
- **SQL Server** for database management.
