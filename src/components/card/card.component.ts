import createElementFromHtml from "../../utils/create-element-from-html";

export class CardComponent {
    constructor(private element: HTMLElement, private htmlHeadline: string) {
        element.appendChild(createElementFromHtml(Handlebars.compile(this.template)({ htmlHeadline: this.htmlHeadline })));
    }

    public template: string = require("./card.component.html");
    public css: string = require("./card.component.scss");
}