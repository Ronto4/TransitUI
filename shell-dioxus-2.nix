# Source: https://nixos.wiki/wiki/Rust

#let
  # Pinned nixpkgs, deterministic. Last updated: 2/12/21.
  # pkgs = import (fetchTarball("https://github.com/NixOS/nixpkgs/archive/a58a0b5098f0c2a389ee70eb69422a052982d990.tar.gz")) {};
  # pkgs = import (fetchTarball("https://github.com/NixOS/nixpkgs/archive/refs/heads/release-24.11.tar.gz")) {};
  # pkgs = import (fetchTarball("https://github.com/NixOS/nixpkgs/archive/refs/heads/master.tar.gz")) {};
  #pkgs = import (fetchTarball("https://github.com/NixOS/nixpkgs/archive/refs/heads/nixos-25.11.tar.gz")) {};
  # pkgs = import (fetchTarball("https://github.com/NixOS/nixpkgs/archive/refs/heads/staging-next.tar.gz")) {};

  # Rolling updates, not deterministic.
  # pkgs = import (fetchTarball("channel:nixos-24.11")) {};
#in
with import <nixpkgs> {};
 pkgs.mkShell {
  buildInputs = [
    pkgs.cargo
    pkgs.rustc
    pkgs.rustfmt
    pkgs.sqlite
    pkgs.postgresql
    pkgs.openssl
    pkgs.pkg-config
    pkgs.clippy
    pkgs.dioxus-cli
    pkgs.libsoup_3
    pkgs.pango
    pkgs.webkitgtk_4_1
    pkgs.xdotool
    pkgs.wasm-bindgen-cli_0_2_100
    pkgs.lld
  ];
  # Source: https://chatgpt.com/c/677fe084-4a50-800e-91d4-153eb63fcd75
  shellHook = ''
    export PATH=$PATH:/home/clemens/.cargo/bin
  '';
}
