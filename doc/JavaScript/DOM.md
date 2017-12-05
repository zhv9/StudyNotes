# DOM

文档模型

## 目录

- [DOM](#dom)
    - [目录](#%E7%9B%AE%E5%BD%95)
    - [节点](#%E8%8A%82%E7%82%B9)
        - [CSS](#css)
    - [获取元素](#%E8%8E%B7%E5%8F%96%E5%85%83%E7%B4%A0)
    - [获取和设置属性](#%E8%8E%B7%E5%8F%96%E5%92%8C%E8%AE%BE%E7%BD%AE%E5%B1%9E%E6%80%A7)
        - [getAttribute](#getattribute)
        - [setAttribute](#setattribute)
    - [总结](#%E6%80%BB%E7%BB%93)

## 节点

包含：元素节点、文本节点、属性节点

1. 元素节点(element node)
    - 例如：`<body>、<p>、<ul>`标签就是元素节点，body、p和ul是元素的名字。
1. 文本节点(text node)
    - `<p>text</p>`起始“p”和结束“p”标签中间的text就是文本节点。
1. 属性节点(attribute node)
    - `<p title="title"></p>`中在起始标签中的title就是属性。

### CSS

语法：

```css
selector{
    property: value;
}
```

1. tag属性
    - selector直接就是tag名称的如“p”、“body”。
    - `p{color: yellow;font-family: "arial", sans-serif;`
    - 具有继承性，节点树上的各个元素将继承其父元素的样式属性，就是如果改了body，body下面的所有元素都会用body所改的样式。
1. class属性
    - selector是“.”加class名
    - `.special{font-style: italic;}`
1. id属性
    - selector是“#”加id名
    - `#purchases{border: 1px solid white;background-color: #333;}`

## 获取元素

1. getElementById
    - 返回一个有对应id的对象。
    - id肯定只有一个，所以只会返回一个。
    - 参数是id，且只有一个参数。
1. getElementsByTagName
    - 返回一个对象数组，每个对象分别对应文档里面有对应标签的元素。
    - 参数是标签名，且只有这一个参数。
1. getElementsByClassName
    - 通过类名来访问，返回一个对象数组
1. 这些getElementBy方法都可以组合使用例如：
    - `var shopping = document.getElementById("purchases");`
    - `var sales = shopping.getElementsByClassName("sales");`
    - 最后sales数组中就只包含位于purchases列表中带有sales类的元素了。

## 获取和设置属性

### getAttribute

`object.getAttribute(attribute)`

- object是获取到的元素节点对象
- getAttribute只能放在元素节点上使用，不能放到document对象上使用(因为不是document对象的方法)
- getAttribute是一个获取属性的函数
- attribute是要获取的属性名称
- 这个函数最终获取到并返回的是属性对应的值，也就是“=”后面的东西。

### setAttribute

`object.setAttribute(attribute, value)`

- 和getAttribute一样也只能作用于元素节点，作用是对对象中的属性赋值。

## 总结

总共介绍了以下几个方法：

- getElementById
- getElementsByTagName
- getElementsByClassName
- getAttribute
- setAttribute

另外还有其他属性和方法，例如：nodeName,nodeValue,childNodes,nextSibling,parentNode