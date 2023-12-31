# Documentation

## Portfolios

<summary>
This Endpoint is to fetch all the portfolios on the platform.
</summary>

<details>

### Get All Portfolios

- **GET** : `/api/explore/GetAllPortfolio` returns 
  ```
  {
  "data": [
    {
    "profilePictureUrl": "path/to/image",
    "profileUrl": "https://localhost:7101/api/explore/getPortfolio/022aca0d-8d73-4632-91a6-b2f0afaf598a",
    "firstName": "Lincoln",
    "lastName": "Elinore",
    "address": "Uptonside, Oman",
    "provider": "Rhett",
    "location": "Uptonside",
    "ranking": "Beginner",
    "track": "Mobile",
    "tag": "British Indian Ocean Territory (Chagos Archipelago)",
    "skills": [],
    "projects": 0
  },
  {
    "profilePictureUrl": "path/to/image",
    "profileUrl": "https://localhost:7101/api/explore/getPortfolio/022aca0d-8d73-4632-91a6-b2f0afaf598a",
    "firstName": "Lincoln",
    "lastName": "Elinore",
    "address": "Uptonside, Oman",
    "provider": "Rhett",
    "location": "Uptonside",
    "ranking": "Beginner",
    "track": "Mobile",
    "tag": "British Indian Ocean Territory (Chagos Archipelago)",
    "skills": [],
    "projects": 0
  }
    
  ],
  "message": "Items retireved successfully",
  "isSuccessful": true,
  "statusCode": 200
    }
  ```

- **GET** : `/api/explore/search/Jaclyn` returns
```
{
  "data": [
    {
    "profileUrl": "Tremayne",
    "firstName": "Lincoln",
    "lastName": "Elinore",
    "address": "Uptonside, Oman",
    "provider": "Rhett",
    "location": "Uptonside",
    "ranking": "Beginner",
    "track": "Mobile",
    "tag": "British Indian Ocean Territory (Chagos Archipelago)",
    "skills": [],
    "projects": 0
  }
  ],
  "message": "Items retireved successfully",
  "isSuccessful": true,
  "statusCode": 200
}
``` 


</details>

<summary>
This documentation provides information about the Portfolio API and how to use the `GetAllPortfolioFilter` endpoint.
</summary>

<detail>


# Portfolio Explorer Filter API Documentation

## Overview

The Portfolio Explorer API provides endpoints to search and filter portfolios of users.

## Get Filtered Portfolios

Returns a list of filtered portfolios based on the specified criteria.

- **URL**: `/api/explore/filter`
- **HTTP Method**: `GET`

### Request Parameters

- `Skill` (Optional): Filters portfolios by skill.
- `Country` (Optional): Filters portfolios by country.
- `Track` (Optional): Filters portfolios by track.
- `Ranking` (Optional): Filters portfolios by ranking.
- `Tag` (Optional): Filters portfolios by tag.
- `Location` (Optional): Filters portfolios by location.
- `Provider` (Optional): Filters portfolios by provider.
- `RoleId` (Optional): Filters portfolios by role ID.
- `SortBy` (Optional): Sorts portfolios by the creation date (`newest` or `oldest).

#### Date Range Parameters (Optional)

- `CreatedAtMin` (Optional): Filters portfolios created after or on this date.
- `CreatedAtMax` (Optional): Filters portfolios created before or on this date.

#### Pagination Parameters (Optional)

- `PageSize` (Optional): Number of items to return per page (default: 10).
- `PageNumber` (Optional): Page number to retrieve (default: 1).

### Response

- **Status Code**: `200 OK`
- **Content Type**: `application/json`
- **Response Body**: A list of portfolios matching the specified criteria.

```json
[
  {
    "ProfileUrl": "https://example.com/profile.jpg",
    "FirstName": "John",
    "LastName": "Doe",
    "Address": "New York, USA",
    "Provider": "XYZ Corp",
    "Location": "New York",
    "Track": "Software Development",
    "Ranking": "Gold",
    "Tag": "Tech Enthusiast",
    "CreatedAt": "2023-10-10T12:34:56",
    "Skills": ["C#", "ASP.NET", "Web Development"],
    "Projects": 5
  },
  // More portfolio entries...
]
```

### Example

```http
GET /api/explore/filter?Skill=Web%20Development&Country=USA&SortBy=newest&PageSize=20&PageNumber=2&CreatedAtMin=2023-09-01&CreatedAtMax=2023-09-30
```

This example requests portfolios for users with the skill "Web Development," in the USA, sorted by the newest portfolios, with a page size of 20 items, retrieving the second page of results, and filtering portfolios created between September 1, 2023, and September 30, 2023.

## Get All Portfolios

Returns a list of all available portfolios.

- **URL**: `/api/explore/GetAllPortfolio`
- **HTTP Method**: `GET`

### Response

- **Status Code**: `200 OK`
- **Content Type**: `application/json`
- **Response Body**: A list of all available portfolios.

```json
[
  {
    "ProfileUrl": "https://example.com/profile.jpg",
    "FirstName": "Jane",
    "LastName": "Smith",
    "Address": "Los Angeles, USA",
    "Provider": "ABC Corp",
    "Location": "Los Angeles",
    "Track": "Data Science",
    "Ranking": "Silver",
    "Tag": "Data Analyst",
    "CreatedAt": "2023-09-20T09:45:00",
    "Skills": ["Python", "Machine Learning"],
    "Projects": 3
  },
  // More portfolio entries...
]
```

</detail>


<summary>
This Endpoint is to fetch all the portfolios on the platform.
</summary>

<details>

### Get a proffolio by ID

- **GET** : `/api/explore/getPortfolio/022aca0d-8d73-4632-91a6-b2f0afaf598a` returns 
  ```
     {
      "data": {
        "id": "022aca0d-8d73-4632-91a6-b2f0afaf598a",
        "profilePictureUrl": null,
        "profileUrl": "https://localhost:7101/api/explore/getPortfolio/022aca0d-8d73-4632-91a6-b2f0afaf598a",
        "firstName": "Scotty",
        "lastName": "Milton",
        "address": null,
        "provider": "Tressie",
        "location": null,
        "ranking": null,
        "track": null,
        "tag": null,
        "createdAt": "0001-01-01T00:00:00",
        "skills": [],
        "projects": 0
      },
      "message": "Portfolio Retrieved",
      "isSuccessful": true,
      "statusCode": 200
    }
  ```
</details>