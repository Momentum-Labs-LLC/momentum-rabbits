# Docker Compose
Starts dynamodb, cognito

# Dynamo DB Tables

# Cognito Setup

## Create the user pool
aws cognito-idp create-user-pool \
    --pool-name rabbits-user-pool \
    --profile local --endpoint-url http://localhost:9229

Use the pool id later.

## Create the user pool client
aws cognito-idp create-user-pool-client \
    --user-pool-id {POOL_ID} \
    --client-name rabbits-user-pool-client \
    --generate-secret \
    --profile local --endpoint-url http://localhost:9229

Record `UserPoolId`, `ClientId`, and `ClientSecret` into `../.vscode/launch.json` environment variables.

## Create a user

aws cognito-idp admin-create-user \
    --user-pool-id {POOL_ID} \
    --username developer \
    --user-attributes Name=email,Value=developer@momentumlabsllc.com Name=phone_number,Value="+15555551212" \
    --message-action SUPPRESS \
    --profile local --endpoint-url http://localhost:9229

## Assign a password

aws cognito-idp admin-set-user-password \
    --user-pool-id local_5svuAwkP \
    --username developer \
    --password P@ssw0rd10 \
    --profile local --endpoint-url http://localhost:9229