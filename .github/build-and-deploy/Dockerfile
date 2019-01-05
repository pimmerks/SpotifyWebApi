FROM microsoft/dotnet:sdk

LABEL "com.github.actions.name"="Build and deploy"
LABEL "com.github.actions.description"="Build and deploy SpotifyWebApi"
LABEL "com.github.actions.icon"="upload"
LABEL "com.github.actions.color"="blue"

COPY . .

RUN chmod +x /entrypoint.sh

ENTRYPOINT ["/entrypoint.sh"]