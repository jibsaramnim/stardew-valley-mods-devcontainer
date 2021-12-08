# Stardew Valley Mod Development compatible devcontainer

A VSCode devcontainer configuration optimized for Stardew Valley mod development. 

The devcontainer has been configured and should fully support Fedora and any other environment that uses selinux.

# Quick Start

The TL;DR of below:

- Make sure you have SMAPI for developers installed
- Create a symlink to your Stardew Valley installation directory called `_gamedirref` in the root of your project (`ln -s /path/to/stardew-valley ./_gamedirref`)
- Build and re-open project in dev container
- Build your mod project using the included build script (`ctrl+shift+b` or `cmd+shift+b`)
- Happy coding! :-)

# Prerequisites

You'll need to have [Docker](https://www.docker.com/) or [Podman](https://podman.io/) installed and set up on your system, and have [Visual Studio Code](https://code.visualstudio.com/) with the [Remote Containers extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) installed.

# Getting Started

If you are starting with creating a new mod, you can use the "Use this template" option to create a repository under your own account with the prerequisite files in place. From there you can simply set up your Stardew Valley mod project as you usually would.

If you already have an existing mod and would like to start using VSCode, you can download clone or download an archive of this repository (Code > Download ZIP) and manually copy the necessary files into your existing repository. At minimum you'll want to copy the `.devcontainer` directory and copy or merge the included `.gitignore` file with your own. The included `.vscode` directory also includes a convenient build task which is configured to be the default build task.

Depending on your preferences you might also want to bring over the `.editorconfig` file, which comes with some sane defaults set, which is used by the [EditorConfig extension](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig) that is automatically installed within the devcontainer.

# Before your first open

Before you can successfully launch the devcontainer, you must first create a symlink to where you have your copy of Stardew Valley with the [developer version of SMAPI](https://smapi.io/) installed. The devcontainer configuration file expects this symlink to be called `_gamedirref` within the project directory.

If, for example, you have Stardew Valley installed at `~/.local/share/Steam/steamapps/common/Stardew Valley`, you could create a symlink like this:

```bash
ln -s ~/.local/share/Steam/steamapps/common/Stardew\ Valley ./_gamedirref
```

The included `.gitignore` file is configured to ignore this symlink, so it will (and should not) not be committed to your project.

With this in place, you can now re-open your project using the devcontainer.

# Usage

Within the container you should have access to the necessary tools, including `msbuild`, `dotnet`, and `nuget`.

Building your project can be done by triggering the included build task (`ctrl+shift+b`, or `cmd+shift+b`) or by running `msbuild` in terminal. Note that this task assumes your mod resides within a subdirectory called `src`.

The container is set up to automatically run `dotnet restore src` after building the container image, but you can re-run this whenever you need to of course. If you instead wish to use the `nuget restore` option, you'll have to either include a `*.sln` solution file in your project, or have a `packages.config` file.

# Contributing

If you have any improvements or suggestions you wish to share, please feel free to open an issue or pull request. Test reports for different environments will also be appreciated. 
