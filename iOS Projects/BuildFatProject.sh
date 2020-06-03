#!/bin/bash

PROJECTNAME="$1"

rm -R "$PROJECTNAME/build"

xcodebuild -sdk iphoneos13.5 -project "./$PROJECTNAME/$PROJECTNAME.xcodeproj" -configuration Release
xcodebuild -sdk iphonesimulator13.5 -project "$PROJECTNAME/$PROJECTNAME.xcodeproj" -configuration Release

cp -R "$PROJECTNAME/build/Release-iphoneos" "$PROJECTNAME/build/Release-fat"
cp -R "$PROJECTNAME/build/Release-iphonesimulator/$PROJECTNAME.framework/Modules/$PROJECTNAME.swiftmodule" "$PROJECTNAME/build/Release-fat/$PROJECTNAME.framework/Modules/$PROJECTNAME.swiftmodule"


lipo -create -output "$PROJECTNAME/build/Release-fat/$PROJECTNAME.framework/$PROJECTNAME" "$PROJECTNAME/build/Release-iphoneos/$PROJECTNAME.framework/$PROJECTNAME" "$PROJECTNAME/build/Release-iphonesimulator/$PROJECTNAME.framework/$PROJECTNAME"

lipo -info "$PROJECTNAME/build/Release-fat/$PROJECTNAME.framework/$PROJECTNAME"


sharpie bind --sdk=iphoneos13.5 --output="$PROJECTNAME/build/${PROJECTNAME}Proxy" --namespace="$PROJECTNAME" --scope="$PROJECTNAME/build/Release-fat/$PROJECTNAME.framework/Headers/" "$PROJECTNAME/build/Release-fat/$PROJECTNAME.framework/Headers/$PROJECTNAME-Swift.h"
