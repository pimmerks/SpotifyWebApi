#!/bin/bash

run() {
    cmd="$@"
    sh -c "$@"

    ERROR_CODE=$?
    if [[ $ERROR_CODE != 0 ]]; then
        echo "Error (code: $ERROR_CODE) when executing command: '$cmd'"
        exit $ERROR_CODE
    fi
}

echo ""
echo "Building"
run "dotnet build -c Release"

echo ""
echo "Testing"
run "dotnet test -c Release Test"