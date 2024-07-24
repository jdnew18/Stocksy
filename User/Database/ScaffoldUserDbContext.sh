cd ..
dotnet ef dbcontext scaffold DataSource=./Database/UserDatabase.db Microsoft.EntityFrameworkCore.Sqlite --output-dir Models --context UserDbContext --data-annotations --no-pluralize --verbose
cd Database