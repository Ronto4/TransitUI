#!/bin/bash

set -e

./startup
docker run -p 3654:80 -d --name transit-web-container transit-web
