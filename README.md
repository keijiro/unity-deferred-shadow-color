unity-deferred-shadow-color
===========================

![fig1](https://github.com/keijiro/unity-deferred-shadow-color/raw/gh-pages/fig1.png)

This is a sample project which shows how to change the shadow color in the deferred lighting pipeline.

You can change the shadow color with "_ShadowManager" object.

![fig2](https://github.com/keijiro/unity-deferred-shadow-color/raw/gh-pages/fig2.png)

This project uses a modified version of Internal-PrePassLighting.shader to support the shadow color.
It runs only on Unity 4.2 because the shader is modified from [the built-in shader in 4.2]
(http://unity3d.com/unity/download/archive). You have to manually modify Internal-PrePassLighting.shader
[like this change]
(https://github.com/keijiro/unity-deferred-shadow-color/commit/5a1b69560cf671ceff8346d4b761f39cbd5d445c)
to run it on the other versions of Unity.
