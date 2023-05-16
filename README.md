# Unity Magic: The Gathering Card Game

This is a WIP project of a Magic: The Gathering based card game developed as a birthday present.

## License and Use

You are free to use, modify, and distribute this code for any purpose. However, please note that some of the assets included in this project may be subject to licensing restrictions. As such, it is your responsibility to ensure that you have the proper permissions and licenses for any assets used in your own projects based on this code.

## Getting Started

### Prerequisites

- Unity 2019.4 or later

### Installation

1. Clone or download the repository.
2. Open the project in Unity.

## Contributing

This project is currently not accepting contributions as it is a personal project. However, feel free to fork the project and make any changes you'd like.

## Current features

- Card Selector: a simple UI that allows the user to browse and select cards from the Card Database.
- Card Database: a class that stores test cards with basic information, such as name, type, and mana cost.
- Card UI Builder/Editor: a tool that allows the user to customize the appearance of the cards, including the background, art, and text.
- Card Screenshot Tool: a tool that takes a screenshot of a card displayed in the Card Selector and converts it into a PNG file.
- Deck Manager: a WIP feature that will allow the player to create and customize their own decks using the cards available in the Card Database.
- Basic game mechanics and card-player/card-card interactions (WIP) Currently the Gamemanager initializes with gameMode=Mode.GAME, wich creates one game with 2 players. The first player receives the information from the PlayerSettings and a new test Player 2. All the necesary information  is created and displayed in console. The selected deck will be a set of random cards from CardDatabase for testing purposes until I refactor de Card and CardDatabase classes, much later on the game development stage. I'm planning on implementing Multiplayer with a Handler class in the GameManager that can be called under some circunstances. The Handler will take both users information in Playersettings to create a match. This may change in the future as I don't have any kind of experience in multiplayer and I may find better ways to implement this future feature

## Future features

- Deck manager (WIP)
- Basic game mechanics and card-player/card-card interactions (WIP)
- Cards special effects and interactions
- Animations and Effects
- Improve Card creation, major refactor of CardDatabase, CardSelector and CardEditor
- Single player basic AI mode
- Multiplayer support
