#!/bin/bash

set -e

./startup.sh
docker run -p 3654:80 --name transit-web-container transit-web
