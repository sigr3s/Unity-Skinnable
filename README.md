Unity Skinnable
============

Skinnable is a tool that allow you to define and apply styles to your unity project in highly customizable way.

This tool uses one special name in the name for the folders that are containing the styles/themes created. It uses specific name folders to avoid having extra files in your project and ensuring the same behaivour in all the envieronments. This folder is called "Styles" and you may have more than one without problem.

Also by default extra folders are created following the Styles/{group}/{type}/ patten to help you keeping your styles/themes ordered and accesible in your project.

All styles are stored as ScriptableObjects under this structure.

![Example video](https://media.giphy.com/media/26lvvngYofw9EOmjNz/giphy.gif)

This project was created in unity 2018.2.7f1 and targeting .Net 4.x Equivalent.

- [Installation](#installation)
- [How to use](#how-to-use)
    - [Components](#components)
        - [Styles Master](#styles-master)
        - [SkinnableComponent](#skinnablecomponent)
    - [Creating an Theme/Style](#creating-an-themestyle)
    - [Adding Styles/Themes](#adding-stylesthemes)
- [Compile](#compile)
- [TODO](#todo)


# Installation

Download one of the unitypackage files from the Releases page and import it to the project.

# How to use

Just add the Skinnable component to a gameobject, select the type of the component and select the style [SkinnableComponent](#skinnablecomponent).

To create styles/themes use the + button on the styles master and the creation wizard will display: [Creating an Theme/Style](#creating-an-themestyle).

To define your own styles/themes follow the section [Adding Styles/Themes](#adding-stylesthemes).


## Styles Master

This is the window that will help you navigate and change your themes/styles in a easy way.

![](https://res.cloudinary.com/dgpo6noqd/image/upload/v1542109938/Skinnable/styleMaster.png)

![](https://res.cloudinary.com/dgpo6noqd/image/upload/v1542109919/Skinnable/Parts_of_a_default_editor.png)
## SkinnableComponent

This is the component that should be added to a GameObject that should be skinned.

![](https://res.cloudinary.com/dgpo6noqd/image/upload/v1542110136/Skinnable/Component.png)

Note that any change there will apply to the source style. Also themes cannot be edited from here to avoid unwanted changes.

## Creating an Theme/Style

Once you click the + button on [Styles Master](#styles-master) window the following one will be shown:

![](https://res.cloudinary.com/dgpo6noqd/image/upload/v1542110137/Skinnable/Create.png)

From here you can select the type of theme/style that you want to create, select the group and the destination folder, name it in a super-fancy way and obiusly fill up the style/theme values.

In order to help you it will not allow you to create empty names for themes (If you want this for some superimportant reason you can modify the generated asset).

## Adding Styles/Themes

In order to create your own style you should create a single .cs file extending BaseStyle<T> where if T:
- Is a MonoBehaibour it will be a style.
- Othewise it will be a theme.

```cs
public class ToggleStyle : BaseStyle<Toggle> {
    public ColorBlock colorBlock;

    public Sprite toggleSprite;

    public override void ApplyStyle(ref System.Object targetObject)
    {
        Toggle toggle = targetObject as Toggle;
        if (toggle != null) {
            if(ShouldApply(nameof(colorBlock))){
                toggle.colors = colorBlock;
            }

            if(ShouldApply(nameof(toggleSprite))){
                Image image = toggle.targetGraphic as Image;
                if(image != null){
                    image.sprite = toggleSprite;
                }
            }
        }
    }
    }

}
```
As you can see in the example to know if we should apply the field we can call:
```cs
    ShouldApply(nameof(field))
```

### Warning!

When you should create a theme of a struct you may want to do it as is in color block as otherwise you will not be able to avoid apllying only one field of the struct.

What if I want a MonoBehaivour beeing an theme?
- Change the editor code of the project.
- Create a struct to hold MonoData and then create the theme of this one.

## Custom editors

Yeah, you can do custom editors for the themes/styles and them will be displayed. But right now there is not a exposed stable api to use the same core functions as the default editor of the tool uses. So I will recommend to use the default until this is exposed in a fancy way.



# Compile

In order to compile and recreate the dlls that come with the unitypackage in releases you will need to follow the next steps:

- Create the skinnablecore dll. With the code inside the Assets/Skinnable/Scripts/Core~ folder. You will need to add as a dependency UnityEngine dll.
- Create the skinnablecore dll. With the code inside the Assets/Skinnable/Scipts/Editor~ folder. You will need to add as a dependency UnityEngine dll.
- Import both dlls targeting skinablecore for all platforms

# TODO

- Clean up EditorForStyle => Now it has a lot of duplicated code for properties/fields
- More visual material (videos, images)
- Add more default styles
- Avoid marking scene as dirty when styles are not modified.
- Add SearchBar to Styles Masters window.
- Beauty editor.
- Nested structs support.
- Property fields support improved (only working on structs).
- Add Unit tests to ensure integrity.