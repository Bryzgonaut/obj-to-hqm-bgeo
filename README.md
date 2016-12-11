# obj-to-hqm-bgeo
A program to convert Wavefront .OBJ files to Hockey? compatible .bgeo (.bhclassic) files

## Status
Currently only works on very simple geometry

## Limitations

- All faces on the .obj model must be triangulated prior to importing
- Large (>10 MB) files may not work properly in-game
- Currently converts to geo, not bgeo (binary) so an additional conversion step is needed. This step can be done in Houdini without causing errors.

## OBJ File Format Documentation

https://en.wikipedia.org/wiki/Wavefront_.obj_file

http://www.martinreddy.net/gfx/3d/OBJ.spec

## GEO (HCLASSIC) File Format Documentation

http://www.sidefx.com/docs/houdini12.0/io/formats/geo

## Sample Files

Included are several sample files to test various aspects of the converter

- humanoid_quad.obj: a simple humanoid model with square faces that should create an error because faces must be triangulated
- humanoid_tri.obj: same model but should only cause a no texture coordinates warning
- player_chest0.bgeo - the default HQM player chest
- player_chest0.hclassic - default HQM player model converted to our desired output format
- player_chest0.obj - default HQM player model converted to our desired input format
