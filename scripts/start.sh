#!/bin/bash

set -e

scripts/startup.sh
docker run -p 3654:80 -d --name transit-web-container transit-web
