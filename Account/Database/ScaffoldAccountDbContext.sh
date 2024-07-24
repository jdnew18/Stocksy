cd ..
dotnet ef dbcontext scaffold DataSource=./Database/AccountDatabase.db Microsoft.EntityFrameworkCore.Sqlite --output-dir Models --context AccountDbContext --data-annotations --no-pluralize --verbose
cd Database