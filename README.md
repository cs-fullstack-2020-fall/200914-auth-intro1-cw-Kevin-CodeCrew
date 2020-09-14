# Authentication/Authorization Intro CW

## Setup:

* Run `dotnet new mvc -o authintrolecture --auth individual`
* Add View compilation to `startup.cs`
  - `dotnet add package Microsoft.AspNetCore.MVC.Razor.RuntimeCompilation`
  ```services.AddControllersWithViews().AddRazorRuntimeCompilation();```
* Update `startup.cs` and add `.AddRoles<IdentityRole>()` to existing `.AddDefaultIdentity` code.

```
services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
  .AddRoles<IdentityRole>()
  .AddEntityFrameworkStores<ApplicationDbContext>();
```
  
```
services.AddMvc(obj =>
{
	var policy = new AuthorizationPolicyBuilder()
		.RequireAuthenticatedUser()
		.Build();
}
```

* Add annotation(s)
`[Authorize]`


1. Create new MVC application with basic authentication
2. Require authentication for the `Policy` option
3. Add a `Customer` model with following properties:
* `id` - int
* `customerFirstName` - string (required)
* `customerLastName` - string (required)
* `customerProfile` - string (required)
4. Add a `List Customerss` view that all users can view
5. Add an `Add Customer` view that requires the user to be logged in before it can be viewed
6. Add a `Edit Customer` view that is linked to from `List Customer View` that requires the user to be logged in before it can be viewed





