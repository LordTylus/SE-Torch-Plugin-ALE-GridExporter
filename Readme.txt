### Introduction

Sometimes you just need a copy of a grid you can either use in Single player, or you want to use for later paste. This is what this plugin offers.

Using the commands below you can export any grid you are looking at or can uniquely be identified by a grid name. 

Note the Essentials plugin has an export and import function for grids already. However its has some downsides as well. 

This plugin can:

- Export and Import grids and all of its subgrids, such as Wheels, Rotors and Pistons
- The exported file will be in standard SE Blueprint format. 
 - So you can also dump it in your blueprint folder and load it normally using Single Player
- If configured export connected grids using connectors as well
- Keep original owner and authorships, of if configured be set to nobody. 
- Identify the grids just by you looking at them. 

### Configuration

Basically there are 3 things you can configure:

- Keep original owner in exported files
 - If you plan to paste grids in the same world it would be useful to use that option, because you wont need to take care of blocklimits etc yourselves then. 
- Grids connected via connection should be exported as well
 - Will either export or ignore grids connected via connector
- Include projector blueprints in export
 - Will either export or ignore projections from block consoles and projector
- Relative savepath from your instances folder
 - By Default grids will be exported to Instances/ExportedGrids. However you can change the folder name, or even add Subfolders if you like. But generally speaking it is not required to change that. 

### Commands

- !exportgrid &lt;filename&gt; [gridname]
 - Exports the grid with the given filename (no extension needed). If you dont pass a grid, the grid you are looking at will be taken. 
- !importgrid &lt;filename&gt; [playername]
 - Imports a grid from a given filename and allows you to spawn it next to any player. If no player is given grids will be spawned next to your character.

### Github
[See here](https://github.com/LordTylus/SE-Torch-Plugin-ALE-GridExporter)