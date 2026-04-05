**SedapMakan Management System**

A database-driven C# desktop application designed to streamline restaurant operations through a multi-role architecture. This project prioritizes data integrity and system security, implementing granular access controls and defensive SQL practices to protect sensitive user and financial data.

🛡️ Security Implementation

Role-Based Access Control (RBAC)
The system employs a strict RBAC model to ensure that users interact only with the data and functions necessary for their specific roles. This prevents unauthorized access to administrative settings or sensitive financial reports.

System Administrator: Full CRUD (Create, Read, Update, Delete) permissions for user management and access to global sales/e-wallet reports.

Manager: Restricted to operational oversight, including feedback management and e-wallet top-up approvals.

Chef: Access limited to the kitchen order queue and order status updates.

Customer: Limited to personal profile management, menu browsing, and order placement via a secure e-wallet.

SQL Injection Prevention (Defensive Security)
A core security feature of this application is the systematic prevention of SQL Injection (SQLi) attacks. Instead of using string concatenation to build database queries—which would allow malicious actors to manipulate command logic—this system exclusively uses Parameterized SQL Queries.

Why this matters:
By using parameters, the database treats user input strictly as data, not as part of the executable command. This "Defensive Security" approach ensures that input like ' OR '1'='1 is neutralized and cannot bypass authentication or leak database records.


🚀 Technical Features
Technology Stack: C# (.NET Framework), Microsoft SQL Server.

Architecture: Object-Oriented Design (OOD) utilizing Inheritance for user roles and Encapsulation for data protection.

Reporting: Dynamic generation of sales and e-wallet usage reports with custom date and category filters.

Transaction Logic: A localized E-Wallet system that manages customer balances with transaction logging to prevent financial discrepancies.

🛠️ Setup and Installation
Clone the repository: git clone https://github.com/AhmedAlvi502/Restaurant-Management-System.git

Database Configuration:

Import the provided .sql schema into your MS SQL Server instance.

Update the ConnectionString in the App.config or database helper class to match your local server credentials.

Build: Open the .sln file in Visual Studio and build the solution.

Run: Start the application to access the login portal.
