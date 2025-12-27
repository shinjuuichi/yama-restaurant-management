# Yama Restaurant Management System

## Overview

Yama is a comprehensive restaurant management system with separate interfaces for customers, staff, and managers. The system handles bookings, product management, employee management, and business analytics.

## Main Features

### 🍽️ Customer Features

- **User Authentication**: Register/Login with email or Google OAuth
- **Browse Menu**: View products with filtering by category and price range
- **Table Booking**: Reserve tables with date/time selection and deposit payment
- **Membership System**: Register for membership to get exclusive vouchers and benefits
- **Feedback & Rating**: Leave reviews on products and services
- **Booking History**: Track past and upcoming reservations
- **Voucher Management**: View and apply available vouchers

### 👨‍💼 Manager Features

- **Dashboard Analytics**: View statistics on bookings, revenues, users, and feedbacks
- **Product Management**: Add, update, remove, and restock menu items
- **Staff Management**: Manage employee information and positions
- **Attendance Management**: Track staff check-in/check-out times
- **Salary Management**: Handle employee salary records
- **Table Management**: Configure and manage restaurant tables
- **User Management**: View all users and approve membership requests
- **Booking Management**: Oversee all customer bookings
- **Contact Management**: Respond to customer inquiries
- **Voucher Management**: Create and manage promotional vouchers

### 👨‍🍳 Staff Features

- **Booking Management**: View and manage table bookings
- **Statistics Dashboard**: Track weekly servings and revenues
- **Profile Management**: Update personal information

## Technology Stack

- **Backend**: ASP.NET Core Web API (.NET)
- **Frontend**: React.js with Material-UI
- **Database**: SQL Server (Entity Framework Core)
- **Authentication**: JWT Token-based
- **Deployment**: Docker with Nginx reverse proxy

## Seed Accounts

### Manager Account

```
Email: employee3@yama.com
Password: Password123!
Role: Manager
```

### Staff Account

```
Email: employee2@yama.com
Password: Password123!
Role: Staff
```

### Customer Account

```
Email: user1@yama.com
Password: Password123!
Role: Customer
```

### Prerequisites

- Node.js 16+
- .NET 6.0+
- SQL Server
- Docker (optional)

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/YamaDrK/yama-restaurant-management.git
   cd yama-restaurant-management
   ```

2. **Backend Setup**

   ```bash
   cd yama-eatery-server/WebAPI
   dotnet restore
   dotnet ef database update
   dotnet run
   ```

3. **Frontend Setup**
   ```bash
   cd yama-eatery-client
   npm install
   npm start
   ```

## License

This project is licensed under the MIT License - see the LICENSE file for details.
