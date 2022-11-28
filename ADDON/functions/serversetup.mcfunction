gamerule sendCommandFeedback false
op @a
gamerule commandBlockOutput false
gamerule keepInventory true
gamerule maxCommandChainLength 100
gamerule showCoordinates true
gamerule spawnRadius 0
fill ~-10 ~-1 ~-10 ~10 ~8 ~10 bedrock 1 hollow
fill ~-9 ~ ~-9 ~9 ~7 ~9 light_block 15
tickingarea add ~-10 ~-1 ~-10 ~10 ~8 ~10 core
tellraw @s {"rawtext":[{"text":"§3Setup Done"}]}