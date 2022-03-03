# See here for image contents: https://github.com/microsoft/vscode-dev-containers/tree/v0.205.2/containers/dotnet/.devcontainer/base.Dockerfile

# [Choice] .NET version: 6.0, 5.0, 3.1, 6.0-bullseye, 5.0-bullseye, 3.1-bullseye, 6.0-focal, 5.0-focal, 3.1-focal
ARG VARIANT="6.0-bullseye-slim"
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT}

# [Choice] Node.js version: none, lts/*, 16, 14, 12, 10
ARG NODE_VERSION="none"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi

# Add the mono-project repository and install mono-complete and msbuild
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends gnupg ca-certificates \
    && apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF \
    && echo "deb https://download.mono-project.com/repo/ubuntu preview-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-preview.list \
    && apt-get update \
    && apt-get install --no-install-recommends -y mono-complete msbuild nuget

# Create a stardewvalley.targets file pointing to /stardew-valley, which is expected
# to be a mounted volume pointing to your Stardew Valley installation (see `devcontainer.json`)
RUN su vscode -c "echo '<Project><PropertyGroup><GamePath>/workspaces/stardew-valley-game/</GamePath><GameModsPath>/workspaces/stardew-valley-game/Mods</GameModsPath></PropertyGroup></Project>' > /home/vscode/stardewvalley.targets"

# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1