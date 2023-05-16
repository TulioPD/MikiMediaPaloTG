/*
//=============================================================================
// WG_Icemenu.js [En-Us]
//=============================================================================

=============================================================================
LICENSE: CC BY 4.0
> Attribution
You must give appropriate credit, provide a link to the license,
and indicate if changes were made. You may do so in any reasonable manner,
but not in any way that suggests the licensor endorses you or your use.

> No additional restrictions
You may not apply legal terms or technological
measures that legally restrict others from doing anything the license permits.

> YOU CANNOT MODIFY THIS SCRIPT AND DISTRIBUTE A NEW SCRIPT BASED ON THIS AND GIVE CREDIT TO YOURSELF WITHOUT CITING THE ORIGINAL AUTHOR
=============================================================================
*/

/*:
 * @plugindesc WG Icemenu | Custom Menu for RMMZ (v.1.0)
 * 
 * @author Sir Lobo
 *
 * @param CustomFont
 * @text Font Name
 * @desc Put your custom font on wg_menu/fonts/ and type here the name exactly as it is there
 * @default HunDIN1451
 *
 * @param UseArtwork
 * @type select
 * @option Yes
 * @value 0
 * @option No
 * @value 1
 * @default 0
 * @desc Allow to use 'artwork.png' on screen
 *
 * @param UseTitleAsImage
 * @type select
 * @option Yes
 * @value 0
 * @option No
 * @value 1
 * @default 0
 * @desc Allow to use 'gamelogo.png' instead title text
 *
 * @param HorizontalPosition
 * @type select
 * @option Left
 * @value 0
 * @option Center
 * @value 1
 * @option Right
 * @value 2
 * @default 2
 * @desc Set horizontal position of the menu
 *
 * @param VerticalPosition
 * @type select
 * @option Center
 * @value 1
 * @option Bottom
 * @value 2
 * @default 2
 * @desc Set vertical position of the menu
 *
 * -------------------------------------------------------------------------
 * @help
 //=========================================================================
 //  WOLFGANG ICE MENU 1.0
 //=========================================================================
 *	
 *	First, put the folder "wg_menu" in your project's root folder
 *	Then copy "WG_icemenu.js" file to the plugins folder
 *	
 *  If you desire to change the font, just:
 *
 *  -Put your custom font on folder "wg_menu/fonts/"
 *  -Change the value from param "Font Name" with the same name of your ".ttf"
 *  -Don't insert the file extension
 *
 *  -------------------------------------------------------------------------
 *  Default Font Name: HunDIN1451
 *  -------------------------------------------------------------------------
 * YOU CANNOT MODIFY THIS SCRIPT AND DISTRIBUTE A NEW SCRIPT BASED ON THIS AND GIVE CREDIT TO YOURSELF WITHOUT CITING THE ORIGINAL AUTHOR
 *
 *  LICENSE: CC BY 4.0
 * > Attribution
 * You must give appropriate credit, provide a link to the license,
 * and indicate if changes were made. You may do so in any reasonable manner,
 * but not in any way that suggests the licensor endorses you or your use.
 *
 * > No additional restrictions
 * You may not apply legal terms or technological
 * measures that legally restrict others from doing anything the license permits.
 *
//=========================================================================
//  Contact Me
//=========================================================================
*
* Username on forums: Sir Lobo
*
* Forum Link: https://centrorpg.com/index.php?action=profile;u=8629
*
* Made with Love by Sir Lobo
* Hope this plugin helps! Keep Howling
* Special thanks to Comuns Team
*/

(() => {
    //Plugin Info & Settings
    const pluginName = "WG Ice Menu";
    const wgpath = '../../wg_menu/';

    //Params
    const parameters = PluginManager.parameters("WG_Icemenu");

    const oParams = {
        CustomFont: String(parameters['CustomFont']),
        HorizontalPosition: String(parameters['HorizontalPosition']),
        VerticalPosition: String(parameters['VerticalPosition']),
        UseTitleAsImage: String(parameters['UseTitleAsImage']),
        UseArtwork: String(parameters['UseArtwork'])
    };

    const oHorizontalPosition = parseInt(oParams.HorizontalPosition);
    const oVerticalPosition = parseInt(oParams.VerticalPosition);
    const oUseTitleAsImage = parseInt(oParams.UseTitleAsImage);
    const oUseArtwork = parseInt(oParams.UseArtwork);

    //Change Window Attributes
	let windowAttrs = Scene_Title.prototype.create;

    Scene_Title.prototype.create = function() {
        windowAttrs.call(this);

        this._commandWindow.opacity = 0;
        this._commandWindow.width = Graphics.width / 2;

        switch(oVerticalPosition)
        {
            case 1:
                this._commandWindow.y = this._commandWindow.width / 2 + 52;
                break;
            case 2:
                this._commandWindow.y = this._commandWindow.width;
                break;
           default:
                this._commandWindow.y = this._commandWindow.width / 2 + 52;
                break;
		}

        switch(oHorizontalPosition)
        {
            case 0:
                this._commandWindow.x = -20;
                break;
            case 1:
                this._commandWindow.x = Graphics.width / 2 / 2;
                break;
            case 2:
                this._commandWindow.x = Graphics.width - 420;
                break;
           default:
                this._commandWindow.x = Graphics.width / 2 / 2;
                break;
		}

		this._commandWindow.windowskin = ImageManager.loadSystem(wgpath + "img/menu_window");
        
        //Remove Content BackSprite
        this._commandWindow._contentsBackSprite.alpha = 0;
    }

    //If horizontal align
    Window_Command.prototype.itemTextAlign = function() {
        switch(oHorizontalPosition)
        {
            case 0:
                return 'left';
                break;
            case 2:
                return 'right';
                break;
           default:
                return 'center';
                break;
		}
    };

    //Cursor BackSprite Width
    Object.defineProperty(Window.prototype, "innerWidth", {
        get: function() {
            return Math.max(0, Graphics.width / 2);
        },
        configurable: true
    });

    //Stop Cursor Blinking
    Window.prototype._makeCursorAlpha = function() {
        const baseAlpha = this.contentsOpacity / 255;
        return baseAlpha;
    };

    //Delete Any Title
    if(oUseTitleAsImage == 0)
    {
        Scene_Title.prototype.drawGameTitle = function()
        {
            const x = 20;
            const y = Graphics.height / 4;
            const maxWidth = Graphics.width - x * 2;
            const text = '';
            const bitmap = this._gameTitleSprite.bitmap;
            bitmap.fontFace = $gameSystem.mainFontFace();
            bitmap.outlineColor = "black";
            bitmap.outlineWidth = 8;
            bitmap.fontSize = 72;
            bitmap.drawText(text, x, y, maxWidth, 48, "center");
        };
    }
    else
    {
        Scene_Title.prototype.drawGameTitle = function()
        {
            const x = 20;
            const y = 65;
            const maxWidth = Graphics.width - x * 2;
            const text = $dataSystem.gameTitle;
            const bitmap = this._gameTitleSprite.bitmap;
            bitmap.fontFace = $gameSystem.mainFontFace();
            bitmap.outlineColor = "black";
            bitmap.outlineWidth = 8;
            bitmap.fontSize = 72;
            bitmap.drawText(text, x, y, maxWidth, 48, "center");
        };
    }

    //Change Font
    FontManager.makeUrl = function(filename)
    {
        if(oParams.CustomFont == null || oParams.CustomFont == "")
        {
            return "fonts/" + Utils.encodeURI(filename);
		}
        else
        {
            return wgpath + "fonts/" + oParams.CustomFont + ".ttf";
		}
    };

    
    /**/

    Scene_Title.prototype.UISprites= function(filename, xPos, yPos) {
        this._mPic = new Sprite();
        this._mPic.bitmap = ImageManager.loadSystem(wgpath + "img/" + filename);
        this._mPic.x = xPos;
        this._mPic.y = yPos;
        this.addChild(this._mPic);
    }

    let MenuMovingPics = Scene_Title.prototype.create;

    Scene_Title.prototype.create = function() {
        MenuMovingPics.call(this);

        switch(oUseTitleAsImage)
        {
            case 0:
                this.UISprites("gamelogo", 0, 0);
                break;
            default:
                //
                break;
		}

        switch(oUseArtwork)
        {
            case 0:
                this.UISprites("artwork", 0, 0);
                break;
            default:
                //
                break;
		}
    }

    /**/

    Window.prototype.update = function() {
    if (this.active) {
        this._animationCount++;
    }
    for (const child of this.children) {
        if (child.update) {
            child.update();
        }
    }
};
})();