{ pkgs }: {
	deps = [
   pkgs.emacs-nox
		pkgs.jq.bin
    pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}