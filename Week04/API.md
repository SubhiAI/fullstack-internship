# Employee Management API

## Overview
This document describes the Employee Management API built with ASP.NET Core and MySQL.

## Base URL
   text
https://localhost:7037

Replace `7037` with the port shown when you run your project.

## Endpoints

### 1. Get All Employees
- **Method:** `GET`
- **URL:** `/api/employees`
- **Request body:** `None`
- **Success response:** `200 OK`

Example response:
```json
[
  {
    "id": 1,
    "name": "Popps",
    "email": "Popps@gmail.com",
    "departmentId": 3,
    "departmentName": "Call Service",
    "jobPositionID": 2,
    "jobPositionTitle": "B"
  }
]
```

An empty array (`[]`) may be returned when there are no employees.

### 2. Get Employee By ID
- **Method:** `GET`
- **URL:** `/api/employees/1`
- **Request body:** None
- **Success response:** `200 OK`
- **Error response:** `404 Not Found` if the employee does not exist and the endpoint handles this case.

Example response:
```json
{
  "id": 2,
    "name": "Crash",
    "email": "Crash@gmail.com",
    "departmentId": 2,
    "departmentName": "HR",
    "jobPositionID": 2,
    "jobPositionTitle": "B"
}
```

### 3. Add Employee
- **Method:** `POST`
- **URL:** `/api/employees`
- **Header:** `Content-Type: application/json`

Example request:
```json
{
  "name": "Ahmad Ali",
  "email": "ahmad@example.com",
  "departmentId": 1,
  "jobPositionID": 2
}
```

Possible success response: `201 Created` or the actual status returned by the controller.

Example response:
```json
{
  "id": 1,
  "name": "Ahmad Ali",
  "email": "ahmad@example.com",
  "departmentId": 1,
  "departmentName": "Software",
  "jobPositionID": 2,
  "jobPositionTitle": "B"
}
```

Possible errors:
- `400 Bad Request`: validation failed (for example, empty name or invalid email).
- `415 Unsupported Media Type`: request content type is not JSON.


### 4. Update Employee
- **Method:** `PUT`
- **URL:** `/api/employees/1`
- **Header:** `Content-Type: application/json`

Example request:
```json
{
  "name": "Ahmad Ali Updated",
  "email": "ahmad.updated@example.com",
  "departmentId": 1,
  "jobPositionID": 2
}
```

Possible success response: `200 OK` or `204 No Content`, depending on the controller.
Possible errors:
- `400 Bad Request`: invalid request data.
- `404 Not Found`: employee does not exist, if handled by the endpoint.
- `415 Unsupported Media Type`: request content type is not JSON.

### 5. Delete Employee
- **Method:** `DELETE`
- **URL:** `/api/employees/1`
- **Request body:** None

Possible success response: `200 OK` or `204 No Content`, depending on the controller.
Possible errors:
- `404 Not Found`: employee does not exist, if handled by the endpoint.

## Validation Rules
The API should validate employee input using DTOs and Data Annotations:
- `Name`: required; maximum 100 characters.
- `Email`: required; must have a valid email format.
- `DepartmentId`: if supplied, should reference an existing department.
- `JobPositionID`: if supplied, should reference an existing job position.

Example invalid request:
```json
{
  "name": "",
  "email": "invalid-email",
  "departmentId": 1,
  "jobPositionID": 2
}
```
Expected response when validation is configured: `400 Bad Request`.

## Error Status Codes
- `400 Bad Request`: invalid input or validation failure.
- `404 Not Found`: requested employee does not exist, when the endpoint handles this case.
- `415 Unsupported Media Type`: unsupported request content type.
- `500 Internal Server Error`: unexpected server-side error.

## Testing Checklist
- [ ] GET all employees.
- [ ] GET an existing employee.
- [ ] GET a nonexistent employee.
- [ ] POST a valid employee.
- [ ] POST an invalid employee.
- [ ] PUT an existing employee.
- [ ] PUT a nonexistent employee.
- [ ] DELETE an existing employee.
- [ ] DELETE a nonexistent employee.

## Notes
- Names, IDs, and response examples are illustrative, not actual database results.
- Confirm actual response bodies and HTTP status codes using Postman or Swagger.
- Ensure the URLs match the routes defined in your controllers.
