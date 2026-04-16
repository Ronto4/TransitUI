{ pkgs ? import (fetchTarball "https://github.com/NixOS/nixpkgs/archive/nixpkgs-unstable.tar.gz") {
    system = "x86_64-linux";
    overlays = [
      (import (fetchTarball "https://github.com/oxalica/rust-overlay/archive/master.tar.gz"))
    ];
  }
}:

let
  rustShellToolchain =
    (pkgs.rust-bin.selectLatestNightlyWith (t: t.default)).override {
      extensions = [ "rust-src" "rust-analyzer" ];
      targets = [ "wasm32-unknown-unknown" ];
    };

  dioxus-cli = pkgs.dioxus-cli.overrideAttrs (_: {
    postPatch = ''
      rm Cargo.lock
      cp ${./Dioxus.lock} Cargo.lock
    '';

    cargoDeps = pkgs.rustPlatform.importCargoLock {
      lockFile = ./Dioxus.lock;
    };
  });

  cargoLock = builtins.fromTOML (builtins.readFile ./Cargo.lock);

  wasmBindgen = pkgs.lib.findFirst
    (pkg: pkg.name == "wasm-bindgen")
    (throw "Could not find wasm-bindgen package")
    cargoLock.package;

  wasm-bindgen-cli = pkgs.buildWasmBindgenCli rec {
    src = pkgs.fetchCrate {
      pname = "wasm-bindgen-cli";
      version = wasmBindgen.version;
      hash = "sha256-txpbTzlrPSEktyT9kSpw4RXQoiSZHm9t3VxeRn//9JI=";
    };

    cargoDeps = pkgs.rustPlatform.fetchCargoVendor {
      inherit src;
      inherit (src) pname version;
      hash = "sha256-J+F9SqTpH3T0MbvlNKVyKnMachgn8UXeoTF0Pk3Xtnc=";
    };
  };

in
pkgs.mkShell {
  name = "dioxus";
  packages = [
    rustShellToolchain
    dioxus-cli
    wasm-bindgen-cli
  ];
}
