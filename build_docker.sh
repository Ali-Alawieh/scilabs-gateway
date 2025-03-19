#!/bin/bash

#BUILD
echo BUILD IMAGE
docker build  -t freigeist21/scilabs-gateway:0.0.3-koffer . 


#PUSH
echo PUSH IMAGE
docker push  freigeist21/scilabs-gateway:0.0.3-koffer
