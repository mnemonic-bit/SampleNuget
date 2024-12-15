
# Welcome to the SampleNuget project

This project is only for instructional purposes to learn how C# projects
can be deployed as Nuget. It has a single csproj, which contains nothing
more than a single class.

There are two points of interest here:
* The `SampleNuget/SampleNuget.csproj` file which contains a lot of useful tags.
* The `.github/workflows/dotnet.yml` file which defines how the parts come all together by means of a Github action.


## How Can We Push Nuget Packages to Nuget.org?

To push Nuget packages to Nuget.org, you need an account on Nuget.org, and
an API key from that site. For this, please log into your Nuget.org account
and navigate to `https://www.nuget.org/account/apikeys`, and then click on
`Create`.Please keep in mind that the key-match-pattern you will configure
while you create a new key, needs to match the name of the PackageId-tag you
have used in your csproj file. Otherwise the Nuget will not be accepted even
with valid API key.

Back on Github you need to add that key to the secrets section of your project.
This section can be found at Settings -> Secrets and Variables -> Actions.
In that section, add a Repository Secret, choose a name (which you will use
in your Github action to reference that secret), and copy over the secret
from your Nuget API Key you've created earlier.

For reference, in this example project, the Secret name is `NUGET_API_KEY`,
which is then used in the Github action.


## How Can We Push Docker Container Images To hub.docker.com or ghcr.io?



## How Can We Enable Debug Log-Messages For Github Actions?

To enable debug log-messages for a Github action, we have to create a secret
in that Github repository whose name is `ACTIONS_STEP_DEBUG`, and which has
to have a value set to `true`.

After that, we can just use any output-generating method of our scripting
language of our choice, e.g. PowerShell, or Bash, and the write a message
into the log of that action.

As an example, we can use write a debug message to the action-log in a
PowerShell script with this line:

```
echo "::debug::This is a debug message."
```

Please note that `::debug` signifies a core-function of the action runner
at Github, which interprets the output of the script, and applies that output
to pre-defined functions / tools. For more information about the syntax of
this commands, please visit the [official documentation](https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does/workflow-commands-for-github-actions).


## Credits and Disclaimer

The inspiration and initial version of the Github action file was taken and
adapted from

```
https://github.com/meziantou/SampleNuGet
```

Since its initial version I have expanded and updated it to match my personal
requirements, and I use it to try out and test ideas for my project-template that
I use for my own projects.

Please use it as it fits your needs.
