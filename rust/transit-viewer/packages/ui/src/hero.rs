use dioxus::prelude::*;

const HERO_CSS: Asset = asset!("/assets/styling/hero.css");
const HEADER_SVG: Asset = asset!("/assets/header.svg");

#[component]
pub fn Hero() -> Element {
    println!("Hello World.");
    let get_response = move |_| async move {
        let response = reqwest::get("https://www.swp-potsdam.de/internetservice/services/passageInfo/stopPassages/stop?stop=290&mode=departure&language=de")
        // let response = reqwest::get("https://dog.ceo/api/breeds/image/random")
            .await
            .unwrap().text().await.unwrap();
        println!("Response: {response:?}");
    };
    // get_response();
    rsx! {
        document::Link { rel: "stylesheet", href: HERO_CSS }

        div {
            id: "hero",
            img { src: HEADER_SVG, id: "header" }
            button { onclick: get_response, id: "fetch", "Fetch!" }
            div { id: "links",
                a { href: "https://dioxuslabs.com/learn/0.7/", "📚 Learn Dioxus" }
                a { href: "https://dioxuslabs.com/awesome", "🚀 Awesome Dioxus" }
                a { href: "https://github.com/dioxus-community/", "📡 Community Libraries" }
                a { href: "https://github.com/DioxusLabs/sdk", "⚙️ Dioxus Development Kit" }
                a { href: "https://marketplace.visualstudio.com/items?itemName=DioxusLabs.dioxus", "💫 VSCode Extension" }
                a { href: "https://discord.gg/XgGxMSkvUM", "👋 Community Discord" }
            }
        }
    }
}
