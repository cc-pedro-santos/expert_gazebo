### GrapqQL Examples:

1) cd MongoQL.Api
2) dotnet run
3) go to -> https://localhost:7290/graphql/

```
{
  actualForecast(
    first: 5,
  ){
    edges {
        cursor
        node {
          id,
          econFunction {
            wrapper {
              ignoreHistoryProd
            }
          }
          createdBy,
          createdAt,
          updatedAt
        }
      }
      pageInfo {
        hasNextPage
      },
      totalCount
    },
}

```

```
{
  tags(
    first: 5,
  ){
    edges {
        cursor
        node {
          _id
          name
          description
          color,
          createdBy,
          createdAt,
          updatedAt
        }
      }
      pageInfo {
        hasNextPage
      },
      totalCount
    },
}

```
