# obj-to-hqm-bgeo
A program to convert Wavefront .OBJ files to Hockey? compatible .bgeo (.bhclassic) files

# Status
Currently only works on very simple geometry

# Limitations

- All faces on the .obj model must be triangulated prior to importing
- Large (>10 MB) files may not work properly in-game
- Currently converts to geo, not bgeo (binary) so an additional conversion step is needed.

# OBJ File Format Documentation

https://en.wikipedia.org/wiki/Wavefront_.obj_file
http://www.martinreddy.net/gfx/3d/OBJ.spec

# GEO (HCLASSIC) File Format Documentation

http://www.sidefx.com/docs/houdini12.0/io/formats/geo
