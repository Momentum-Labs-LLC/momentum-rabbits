locals {
  env         = "local"
  corp        = "momentum"
  iteration   = 0
  region      = "us-east-1"
  project     = "rabbits"
  subproject  = "auth"
  name_prefix = "${local.corp}-${local.env}-${local.project}-${local.subproject}"

  tags = {
    Production = "true"
    Project    = "${local.project}-${local.subproject}"
  }
}

provider "aws" {
  region = local.region
  default_tags {
    tags = {
      Environment = local.env
      Production = "true"
      Project    = "${local.project}-${local.subproject}"
    }
  }
}

resource "aws_cognito_user_pool" "user_pool" {
  name = "user-pool"  
  
  username_attributes = ["email"]
  auto_verified_attributes = ["email"]
  user_attribute_update_settings {
    attributes_require_verification_before_update = ["email"]
  }

  password_policy {
    minimum_length = 8
    require_lowercase = true
    require_numbers = true
    require_symbols = true
    require_uppercase = true
    temporary_password_validity_days = 3 // 3 days
  }

  verification_message_template {
    default_email_option = "CONFIRM_WITH_LINK"
    email_subject_by_link = "Account Confirmation - ${local.project} (${local.env})"
    email_message_by_link = "{##Click Here##} to verify your email."
  }

  mfa_configuration = "OPTIONAL"
  software_token_mfa_configuration {
    enabled = true
  }

  schema {
    attribute_data_type      = "String"
    developer_only_attribute = false
    mutable                  = true
    name                     = "email"
    required                 = true

    string_attribute_constraints {
      min_length = 1
      max_length = 256
    }
  }
}