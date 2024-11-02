
# Welcome to the SampleNuget project

This project is only for instructional purposes to learn how C# projects
can be deployed as Nuget. It has a single csproj, which contains nothing
more than a single class.

There are two points of interest here:
* The `SampleNuget/SampleNuget.csproj` file which contains a lot of useful tags
* The `.github/workflows/dotnet.yml` file which defines how the parts come all together with the means of a Github action.


## How Can Push Nuget Packages to Nuget.org?

To push Nuget packages to Nuget.org, you need an account on Nuget.org, and
an API key. For this, please log into your Nuget.org account and navigate
to `https://www.nuget.org/account/apikeys`, and then click on `Create`.Please
keep in mind that the key match-pattern you will configure while you create
a new key, needs to match the name of the assembly you will push from Github.com.

On Github you need to add that key to the secrets section of your project.
This section can be found at Settings -> Secrets and Variables -> Actions.
In that section, add a Repository Secret, choose a name (which you will use
in your Github action to reference that secret), and copy over the secret
from your Nuget API Key you've created earlier.

For reference, in this example project, the Secret name is `NUGET_API_KEY`,
which is then used in the Github action.


## Credits and Disclaimer

The initial version of this project was taken and adapted from

```
https://github.com/meziantou/SampleNuGet
```

Since its initial version it has been expanded and updated to match my personal
requirements, and I use it to try and test my template that I use for my own projects.

Please use it as it fits your needs.
