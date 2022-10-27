# Orcs

## Turn based fighting game
----------
### Features

#### Battle Orcs
- Fight to the death
- Defend to fight another day

#### Weapons
- Equip a weapon

#### Shop store
- Visit store
- Buy an item
- Sell an item

#### Strength
- Manage player strength

#### Health
- Manage player health

#### Inventory
- Add item to inventory

#### Money
- Manage player gold

----------

### Data Model

Game is the root model. Everything belongs to the game

Game has one store

Game has one to many levels

Game has one player

Game has one to many monsters

Store has one to many inventory items

Level has one to 3 rounds

Basic player has 1 to 3 inventory items

Basic player has 1 to 3 weapons

Basic player has strength. This is damage inflicted against an Orc

Basic player has health. This is defense against Orc weapons and potions. Health is restored between rounds or if player buys a med kit.


