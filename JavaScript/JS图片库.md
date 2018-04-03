# JavaScript图片库

## 目录

## 相关的HTML代码

> 基本的代码

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>Image Gallery</title>
</head>
<body>
    <h1>Snapshots</h1>
    <ul>
        <li>
            <a href="images/fireworks.jpg" title="fireworks display">Fireworks</a>
        </li>
        <li>
            <a href="images/coffee.jpg" title="A cup of coffee">Coffee</a>
        </li>
        <li>
            <a href="images/rose.jpg" title="A red rose">Rose</a>
        </li>
    </ul>
</body>
</html>
```

> 将图片显示到链接下方，增加一个图片占位符

`<img id="placeholder" src="images/placeholder.jpg alt="my image gallery" />`

这样就可以通过getElementById找到这个占位符，并给src赋值来改变实际显示的图片了。

## 修改占位符的方法

截获链接的onclick事件，获取被点击的链接的href。
获取 id 为 placeholder 的节点：`document.GetElementById("placeholder)`
修改src属性为被鼠标点击链接中的href属性的值。

