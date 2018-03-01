if (!(Test-Path '..\..\App.config')) {
    echo 'Copying App.template.config to App.config and applying environment variables.'
    (gc '..\..\App.template.config') -replace '%clientid%', $env:TEST_CLIENTID -replace '%clientsecret%', $env:TEST_CLIENTSECRET -replace '%redirecturi%', $env:TEST_REDIRECTURI | Out-File '..\..\App.config' -Encoding UTF8
}else{
    echo 'App.config already exists.'
}