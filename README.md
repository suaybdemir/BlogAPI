<p align="center">
  <img src="https://img.icons8.com/?size=512&id=55494&format=png" width="20%" alt="BLOGAPI-logo">
</p>
<p align="center">
    <h1 align="center">BLOGAPI</h1>
</p>
<p align="center">
    <em><code>❯ Blog Api</code></em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/suaybdemir/BlogAPI?style=flat&logo=opensourceinitiative&logoColor=white&color=f1f1f1" alt="license">
	<img src="https://img.shields.io/github/last-commit/suaybdemir/BlogAPI?style=flat&logo=git&logoColor=white&color=f1f1f1" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/suaybdemir/BlogAPI?style=flat&color=f1f1f1" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/suaybdemir/BlogAPI?style=flat&color=f1f1f1" alt="repo-language-count">
</p>
<p align="center">
		<em>Built with the tools and technologies:</em>
</p>
<p align="center">
	<img src="https://img.shields.io/badge/JSON-000000.svg?style=flat&logo=JSON&logoColor=white" alt="JSON">
</p>

<br>

#####  Table of Contents

- [ Overview](#-overview)
- [ Features](#-features)
- [ Repository Structure](#-repository-structure)
- [ Modules](#-modules)
- [ Getting Started](#-getting-started)
    - [ Prerequisites](#-prerequisites)
    - [ Installation](#-installation)
    - [ Usage](#-usage)
    - [ Tests](#-tests)
- [ Project Roadmap](#-project-roadmap)
- [ Contributing](#-contributing)
- [ License](#-license)
- [ Acknowledgments](#-acknowledgments)

---

##  Overview

<code>❯ Developed as to implementing Blog Sites</code>

---

##  Features

<code>❯ Comments,Comment to comments,Posts,Images,Authentication</code>

---

##  Repository Structure

```sh
└── BlogAPI/
    ├── BlogAPI
    │   │   ├── BlogAPI
    │   ├── BlogAPI
    │   │   ├── BlogAPI.csproj
    │   │   ├── BlogAPI.csproj.user
    │   │   ├── Controllers
    │   │   │   ├── AuthenticationController.cs
    │   │   │   ├── CommentsController.cs
    │   │   │   ├── MembersController.cs
    │   │   │   ├── PostsController.cs
    │   │   │   ├── RolesController.cs
    │   │   │   └── SubCommentsController.cs
    │   │   ├── Data
    │   │   │   └── ApplicationContext.cs
    │   │   ├── Models
    │   │   │   └── Domain
    │   │   │       ├── Abstract
    │   │   │       └── Concrete
    │   │   ├── Program.cs
    │   │   ├── Properties
    │   │   │   └── launchSettings.json
    │   │   ├── appsettings.Development.json
    │   │   ├── appsettings.json
    │   └── BlogAPI.sln
    └── README.md
```

---

##  Modules

<details closed><summary>BlogAPI.BlogAPI</summary>

| File | Summary |
| --- | --- |
| [BlogAPI.csproj](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/BlogAPI.csproj) | <code>❯ REPLACE-ME</code> |
| [appsettings.json](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/appsettings.json) | <code>❯ REPLACE-ME</code> |
| [appsettings.Development.json](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/appsettings.Development.json) | <code>❯ REPLACE-ME</code> |
| [Program.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Program.cs) | <code>❯ REPLACE-ME</code> |

</details>

<details closed><summary>BlogAPI.BlogAPI.Properties</summary>

| File | Summary |
| --- | --- |
| [launchSettings.json](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Properties/launchSettings.json) | <code>❯ REPLACE-ME</code> |

</details>


<details closed><summary>BlogAPI.BlogAPI.Data</summary>

| File | Summary |
| --- | --- |
| [ApplicationContext.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Data/ApplicationContext.cs) | <code>❯ ApplicationContext</code> |

</details>

<details closed><summary>BlogAPI.BlogAPI.Models.Domain.Concrete</summary>

| File | Summary |
| --- | --- |
| [Member.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Concrete/Member.cs) | <code>❯ Member</code> |
| [Post.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Concrete/Post.cs) | <code>❯ Post</code> |
| [ApplicationUser.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Concrete/ApplicationUser.cs) | <code>❯ ApplicationUser</code> |
| [SubComment.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Concrete/SubComment.cs) | <code>❯ SubComment</code> |
| [Comment.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Concrete/Comment.cs) | <code>❯ Comment</code> |

</details>

<details closed><summary>BlogAPI.BlogAPI.Models.Domain.Abstract</summary>

| File | Summary |
| --- | --- |
| [AbstractComment.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Abstract/AbstractComment.cs) | <code>❯ AbstractComment</code> |
| [AbstractPerson.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Models/Domain/Abstract/AbstractPerson.cs) | <code>❯ AbstractPerson</code> |

</details>

<details closed><summary>BlogAPI.BlogAPI.Controllers</summary>

| File | Summary |
| --- | --- |
| [SubCommentsController.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Controllers/SubCommentsController.cs) | <code>❯ SubCommentsController</code> |
| [MembersController.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Controllers/MembersController.cs) | <code>❯ MembersController</code> |
| [AuthenticationController.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Controllers/AuthenticationController.cs) | <code>❯ AuthenticationController</code> |
| [RolesController.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Controllers/RolesController.cs) | <code>❯ RolesController</code> |
| [CommentsController.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Controllers/CommentsController.cs) | <code>❯ CommentsController</code> |
| [PostsController.cs](https://github.com/suaybdemir/BlogAPI/blob/main/BlogAPI/BlogAPI/Controllers/PostsController.cs) | <code>❯ PostsController</code> |

</details>

---

##  Getting Started

###  Prerequisites

**.Net Core**: `6.0`

###  Installation

Build the project from source:

1. Clone the BlogAPI repository:
```sh
❯ git clone https://github.com/suaybdemir/BlogAPI
```

2. Navigate to the project directory:
```sh
❯ cd BlogAPI
```

3. Install the required dependencies:
```sh
❯ dotnet build
```

###  Usage

To run the project, execute the following command:

```sh
❯ dotnet run
```

###  Tests

Execute the test suite using the following command:

```sh
❯ dotnet test
```

##  Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Report Issues](https://github.com/suaybdemir/BlogAPI/issues)**: Submit bugs found or log feature requests for the `BlogAPI` project.
- **[Submit Pull Requests](https://github.com/suaybdemir/BlogAPI/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/suaybdemir/BlogAPI/discussions)**: Share your insights, provide feedback, or ask questions.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/suaybdemir/BlogAPI
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="left">
   <a href="https://github.com{/suaybdemir/BlogAPI/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=suaybdemir/BlogAPI">
   </a>
</p>
</details>

---
