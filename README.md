# Bakery Shop E-commerce Project

## Project Overview
This project is an e-commerce platform for a bakery shop that allows customers to browse, add items to their cart, and make secure online purchases. It is built using .NET Core Razor Pages for the frontend, EF Core for database management, and SQL Server as the database. The project also features email integration via SMTP4Dev for order confirmations.

## Features
- **Product Management**: Add, update, read, and delete products.
- **Shopping Cart**: Customers can add and remove items from the cart.
- **Cookies**: Used to persist cart data across sessions.
- **Checkout Page**: Seamless checkout process for a smooth user experience.
- **Email Integration**: Order confirmations sent using SMTP4Dev.
- **Responsive Design**: Styled using Bootstrap and JavaScript for optimal performance.

## Technologies Used
- **Frontend**: .NET Core Razor Pages, Bootstrap, JavaScript
- **Backend**: .NET Core, Entity Framework (EF) Core
- **Database**: SQL Server
- **Email Integration**: SMTP4Dev for testing email functionality

## Installation & Setup
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Nilesh-Nath/The-Bakery-Bliss

2. **Navigate to the Project Directory**:
    
    cd bakery-shop-ecommerce
3. **Restore NuGet Packages**:

    dotnet restore
4. **Set Up the Database**:
    Ensure SQL Server is running.
    Update the connection string in program.cs.
5. **Run the database migrations**:

    dotnet ef database update
6. **Run the Project**:

    dotnet run

## Usage
    Navigate to the site in your browser.
    Browse products, add items to the cart, and proceed to the checkout page.
    Complete the purchase and receive email confirmations.