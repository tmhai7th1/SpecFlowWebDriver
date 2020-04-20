#!/bin/bash 
cd "$(dirname "$(realpath "$0")")";
mvn clean -Dtest=NoTransTest test 