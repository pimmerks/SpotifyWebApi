FROM microsoft/dotnet:sdk

LABEL "com.github.actions.name"="Build and test"
LABEL "com.github.actions.description"="Build and test SpotifyWebApi"
LABEL "com.github.actions.icon"="box"
LABEL "com.github.actions.color"="blue"

COPY . .

RUN chmod +x /entrypoint.sh

ENTRYPOINT ["/entrypoint.sh"]