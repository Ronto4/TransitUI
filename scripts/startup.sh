#!/bin/bash

set -e

docker kill transit-web-container
docker rm transit-web-container
docker build -f TransitWeb/Dockerfile -t transit-web .
