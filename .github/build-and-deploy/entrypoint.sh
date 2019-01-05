#!/bin/bash

run() {
    cmd="$@"
    sh -c "$@"

    ERROR_CODE=$?
    if [[ ERROR_CODE -ne 0 ]]; then
        printf "Error (code: $ERROR_CODE) when executing command: '$cmd'"
        exit $ERROR_CODE
    fi
}

checkTag() {
    v="$@"

    if [[ $v =~ ^v[0-9]+\.[0-9]+\.[0-9]+$ ]]; then
        echo "Version ($v) matches proper tag."
    else
        echo "Version ($v) does not match! Must be like: 'v1.0.1' or 'v1.10.12'"
        exit 1
    fi
}

# Get latest git tag
TAG="$(git describe --tags)"
echo TAG: $TAG

# Check tag
checkTag $TAG
VERSION=${TAG:1}

echo Using version: $VERSION

echo "Building"
run "dotnet build -c Release -p:Version=$VERSION"

echo "Testing"
run "dotnet test -c Release Test"

echo "Packing"
run "dotnet pack ./SpotifyWebApi/SpotifyWebApi.csproj -c Release -o ../Publish -p:Version=$VERSION --include-symbols -p:SymbolPackageFormat=snupkg"

echo "Publishing"
run "dotnet nuget push Publish/**/*.nupkg -s $NUGET_SERVER_URI -k $NUGET_API_KEY"